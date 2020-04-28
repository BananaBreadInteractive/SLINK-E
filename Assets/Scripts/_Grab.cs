using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Grab : MonoBehaviour
{
    [SerializeField] private Controls _controls; //Input Action Script
    private Vector2 arms; //The position of the the control stick that moves the players arms
    private Vector3 leftWristPos, rightWristPos; // Position of the arms in the last frame
    private float speed = 8f; // Speed the player arms move
    private Rigidbody2D rbR, rbL; // Left and Right hand rigidbodies
    private float handRadius = 0.2f; // Radius of the hands overlap circle
    private float bodyRadius = 0.45f; // Radius of the 

    public Rigidbody2D head; // Rigidbody of the players head
    public Transform leftWrist, rightWrist; // References the position of the wrists
    public Transform leftHand, rightHand; // References the position of the hands
    public LayerMask WhatIsGrab; // Layer mask to check what the player can grab 
    public bool leftCanGrab, rightCanGrab; // Checks to see if the players hands can grab a surface
    public bool leftGrabbing, rightGrabbing; // Checks to see if the players hands can grab a surface
    public bool grounded; // Checks to see if the player is grounded

    public Sprite open, closed; // Images for the open and closed claws

    private void Awake()
    {
        _controls = new Controls();
    }

    private void Start()
    {
        rbR = rightWrist.GetComponent<Rigidbody2D>();
        rbL = leftWrist.GetComponent<Rigidbody2D>();

        // Sets the position of the hand in the previous frame
        leftWristPos = leftWrist.position;
        rightWristPos = rightWrist.position;
    }

    void OnEnable()
    {
        _controls.Player.Enable();
        _controls.Player.Arms.performed += ctx => arms = ctx.ReadValue<Vector2>(); // Reads the value of the left stick as x and y values
        _controls.Player.Arms.performed += ctx => grounded = false;

        _controls.Player.Arms.canceled += ctx => arms = Vector2.zero; // Set the vector to zero when the stick is not being controlled
        _controls.Player.Arms.canceled += ctx => grounded = true;

        // Pressed Actions
        _controls.Player.LeftHand.performed += ctx => LeftClose();
        _controls.Player.RightHand.performed += ctx => RightClose();

        // Release Actions
        _controls.Player.LeftHand.canceled += ctx => LeftOpen();
        _controls.Player.RightHand.canceled += ctx => RightOpen();
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

        if (leftGrabbing)
        {
            //rbL.constraints = RigidbodyConstraints2D.FreezePosition;
        }

        if (rightGrabbing)
        {
            rbR.constraints = RigidbodyConstraints2D.FreezePosition;
        }

        Vector3.Lerp(rightWristPos, leftWrist.position, 1f);
        Vector3.Lerp(leftWristPos, transform.position, 1f);

        leftCanGrab = Physics2D.OverlapCircle(leftHand.transform.position, handRadius, WhatIsGrab); // Bool checks if the overlapsphere collides with layer mask for both hands
        rightCanGrab = Physics2D.OverlapCircle(rightHand.transform.position, handRadius, WhatIsGrab);
        grounded = Physics2D.OverlapCircle(head.transform.position, bodyRadius, WhatIsGrab);

    }

    private void LeftClose()
    {
        leftHand.GetComponent<SpriteRenderer>().sprite = closed;

        if (leftCanGrab)
        {
            leftGrabbing = true;
        }
    }

    private void RightClose()
    {
        rightHand.GetComponent<SpriteRenderer>().sprite = closed;

        if (rightCanGrab)
        {
            rightGrabbing = true;
        }
    }

    // Opens the players hand and allows the rigid body to move again
    private void LeftOpen()
    {
        leftHand.GetComponent<SpriteRenderer>().sprite = open;
        leftGrabbing = false;

        if (rbL.constraints == RigidbodyConstraints2D.FreezePosition)
        {
            rbL.constraints = RigidbodyConstraints2D.None;
        }
    }

    private void RightOpen()
    {
        rightHand.GetComponent<SpriteRenderer>().sprite = open;
        rightGrabbing = false;

        if (rbR.constraints == RigidbodyConstraints2D.FreezePosition)
        {
            rbR.constraints = RigidbodyConstraints2D.None;
        }
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
