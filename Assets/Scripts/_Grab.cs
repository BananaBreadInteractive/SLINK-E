using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class _Grab : MonoBehaviour // Moves the players hands and allows the player to climb
{
    [SerializeField] private Controls _controls; //Input Action Script
    private Vector2 arms; //The position of the the control stick that moves the players arms
    private Vector3 leftWristPos, rightWristPos; // Position of the arms in the last frame
    private float speed = 8f; // Speed the player arms move


    private Rigidbody2D rbR, rbL; // Left and Right hand rigidbodies
    public Rigidbody2D head; // Rigidbody of the players head
    public Rigidbody2D attachedRb; // The object the hands are grabbing
    private FixedJoint2D fjR, fjL; // Fixed joint components of the hands
    public Transform leftWrist, rightWrist; // References the position of the wrists
    public Transform leftHand, rightHand; // References the position of the hands


    private float handRadius = 0.25f; // Radius of the hands overlap circle
    private float bodyRadius = 0.45f; // Radius of the ground check
    public LayerMask WhatIsGrab; // Layer mask to check what the player can grab 
    public LayerMask WhatIsCog;
    public LayerMask WhatIsDeath;
    public bool leftCanGrab, rightCanGrab; // Checks to see if the players hands can grab a surface
    public bool leftGrabbing, rightGrabbing; // Checks if the grab buttons are being pressed
    public bool grounded, dead;
    public bool cogL, cogR;

    private PlayerIndex playerIndex;
    private GamePadState state;
    private GamePadState prevState;

    public Sprite open, closed; // Images for the open and closed claws

    private void Awake()
    {
        _controls = new Controls();
    }

    private void Start()
    {
        rbR = rightWrist.GetComponent<Rigidbody2D>();
        rbL = leftWrist.GetComponent<Rigidbody2D>();

        fjR = rightWrist.GetComponent<FixedJoint2D>();
        fjL = leftWrist.GetComponent<FixedJoint2D>();

        // Sets the position of the hand in the previous frame
        leftWristPos = leftWrist.position;
        rightWristPos = rightWrist.position;
    }

    void OnEnable()
    {
        _controls.Player.Enable();

        // Pressed Actions
        _controls.Player.LeftHand.performed += ctx => LeftClose();
        _controls.Player.RightHand.performed += ctx => RightClose();
        _controls.Player.Arms.performed += ctx => arms = ctx.ReadValue<Vector2>(); // Reads the value of the left stick as x and y values
        _controls.Player.Arms.performed += ctx => grounded = false; // Allows the player's body to move freely mid-air
        _controls.Player.LeftHand.performed += ctx => leftGrabbing = true;
        _controls.Player.RightHand.performed += ctx => rightGrabbing = true;

        // Release Actions
        _controls.Player.LeftHand.canceled += ctx => LeftOpen();
        _controls.Player.RightHand.canceled += ctx => RightOpen();
        _controls.Player.Arms.canceled += ctx => arms = Vector2.zero; // Set the vector to zero when the stick is not being controlled
        _controls.Player.Arms.canceled += ctx => grounded = true; // Returns the player to a groudned state
    }

    // Stops listening for Inputs when no buttons are being pressed
    void OnDisable()
    {
        _controls.Player.Disable();
    }

    private void FixedUpdate()
    {
        Vector2 armVector = new Vector2(arms.x, arms.y) * Time.deltaTime * speed;


        if (!grounded)
        {
            rbL.AddForce(armVector * 500f);
            rbR.AddForce(armVector * 500f);
        }

        if (leftCanGrab || rightCanGrab)
        {
            head.AddForce(new Vector3(armVector.x, armVector.y * 3f, 0) * 180f);
        }

        if (leftGrabbing && leftCanGrab)
        {
            rbL.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        else
        {
            rbL.constraints = RigidbodyConstraints2D.None;
        }

        if (rightGrabbing && rightCanGrab)
        {
            rbR.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        else
        {
            rbR.constraints = RigidbodyConstraints2D.None;
        }

        if (cogL && leftGrabbing)
        {
            fjL.enabled = true;
            fjL.connectedBody = attachedRb;
        }
        if(!leftGrabbing)
        {
            fjL.enabled = false;
        }

        if (cogR && rightGrabbing)
        {
            fjR.enabled = true;
            fjR.connectedBody = attachedRb;
        }
        if(!rightGrabbing)
        {
            fjR.enabled = false;
        }

        if (dead)
        {
            GamePad.SetVibration(playerIndex, 0.5f, 0.5f);
        }
        else
        {
            GamePad.SetVibration(playerIndex, 0f, 0f);
        }

        Vector3.Lerp(rightWristPos, leftWrist.position, 1f);
        Vector3.Lerp(leftWristPos, transform.position, 1f);

        leftCanGrab = Physics2D.OverlapCircle(leftHand.transform.position, handRadius, WhatIsGrab); // Bool checks if the overlapsphere collides with layer mask for both hands
        rightCanGrab = Physics2D.OverlapCircle(rightHand.transform.position, handRadius, WhatIsGrab);
        grounded = Physics2D.OverlapCircle(head.transform.position, bodyRadius, WhatIsGrab);
        dead = Physics2D.OverlapCircle(head.transform.position, bodyRadius, WhatIsDeath);
        cogL = Physics2D.OverlapCircle(leftHand.transform.position, handRadius, WhatIsCog);
        cogR = Physics2D.OverlapCircle(rightHand.transform.position, handRadius, WhatIsCog);

    }

    private void LeftClose()
    {
        leftHand.GetComponent<SpriteRenderer>().sprite = closed;
        leftGrabbing = true;
    }

    private void RightClose()
    {
        rightHand.GetComponent<SpriteRenderer>().sprite = closed;
        rightGrabbing = true;

    }

    // Opens the players hand and allows the rigid body to move again
    private void LeftOpen()
    {
        leftHand.GetComponent<SpriteRenderer>().sprite = open;
        leftGrabbing = false;        
    }

    private void RightOpen()
    {
        rightHand.GetComponent<SpriteRenderer>().sprite = open;
        rightGrabbing = false;
    }

    // Draws a the overlap circle for each hand
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue; // Draws the left hand circle blue
        Gizmos.DrawWireSphere(leftHand.position, handRadius);
        Gizmos.color = Color.red;// Draws the right hand circle red
        Gizmos.DrawWireSphere(rightHand.position, handRadius);
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(head.position, bodyRadius);
    }

}
