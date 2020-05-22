using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using XInputDotNetPure;

public class PlayerController : MonoBehaviour // Moves the players hands and allows the player to climb
{
    [SerializeField] private Controls _controls; //Input Action Script
    private Vector2 arms; //The position of the the control stick that moves the players arms
    private Vector3 leftWristPos, rightWristPos; // Position of the arms in the last frame
    private float speed = 8f; // Speed the player arms move


    private Rigidbody2D rbR, rbL; // Left and Right hand rigidbodies
    public Rigidbody2D head; // Rigidbody of the players head
    [HideInInspector] public Rigidbody2D attachedRb; // The object the hands are grabbing
    private FixedJoint2D fjR, fjL; // Fixed joint components of the hands
    public Transform leftWrist, rightWrist; // References the position of the wrists
    public Transform leftHand, rightHand; // References the position of the hands


    private float handRadius = 0.35f; // Radius of the hands overlap circle
    private float bodyRadius = 0.49f; // Radius of the ground check
    private float cogRadius = 1f; // Radius of the ground check
    public LayerMask WhatIsGrab; // Layer mask to check what the player can grab 
    public LayerMask WhatIsCog;
    public LayerMask WhatIsDeath;
    public bool leftCanGrab, rightCanGrab; // Checks to see if the players hands can grab a surface
    public bool leftGrabbing, rightGrabbing; // Checks if the grab buttons are being pressed
    public bool grounded, dead;
    public bool cogL, cogR;
    public bool levelComplete;
    public bool hardReseting;
    [SerializeField] private float selected = 0;
    private Scene currentScene;

    private PlayerIndex playerIndex;

    public Sprite open, closed; // Images for the open and closed claws

    private AudioManager _audioManager;
    private UIManager _uiManager;
    private ResetPlayer _resetPlayer;
    private LevelIntro _levelIntro;

    private void Awake()
    {
        _controls = new Controls();
        _audioManager = FindObjectOfType<AudioManager>();
        _audioManager.Play("MusicLoop");
        _audioManager.Play("Ambience");
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

        
        _uiManager = FindObjectOfType<UIManager>();
        _resetPlayer = FindObjectOfType<ResetPlayer>();

        currentScene = SceneManager.GetActiveScene();
    }

    void OnEnable()
    {
        _controls.Player.Enable();

        // Pressed Actions
        _controls.Player.Arms.performed += ctx => arms = ctx.ReadValue<Vector2>(); // Reads the value of the left stick as x and y values
        _controls.Player.Y.performed += ctx => HardReset();
        _controls.Player.Select.started += ctx => selected = _controls.Player.Select.ReadValue<float>();

        _controls.Player.LeftHand.performed += ctx => LeftClose();
        _controls.Player.RightHand.performed += ctx => RightClose();

        _controls.Player.LeftHand.performed += ctx => leftGrabbing = true;
        _controls.Player.RightHand.performed += ctx => rightGrabbing = true;

        _controls.Player.Start.performed += ctx => _uiManager.ShowPause();
        _controls.Player.Start.performed += ctx => _audioManager.Play("MenuSwoosh1");

        // Release Actions
        _controls.Player.Arms.canceled += ctx => arms = Vector2.zero; // Set the vector to zero when the stick is not being controlled
        _controls.Player.Select.canceled += ctx => selected = 0;

        _controls.Player.LeftHand.canceled += ctx => LeftOpen();
        _controls.Player.RightHand.canceled += ctx => RightOpen();

        _controls.Player.Y.canceled += ctx => CancelReset();
    }

    // Stops listening for Inputs when no buttons are being pressed
    void OnDisable()
    {
        _controls.Player.Disable();
    }

    private void FixedUpdate()
    {
        Vector2 armVector = new Vector2(arms.x, arms.y) * Time.deltaTime * speed;

        if (grounded)
        {
            head.AddForce(armVector * 200f);
        }

        if (!grounded)
        {

            head.AddForce(armVector * 600f);

            if (leftCanGrab || cogL)
            {
                if(leftGrabbing)
                {
                    rbL.AddForce(armVector * 500f);
                    rbR.AddForce(armVector * 500f);
                }
            }
            else
            {
                rbL.AddForce(armVector);
            }

            if (rightCanGrab || cogR)
            {
                if (rightGrabbing)
                {
                    rbL.AddForce(armVector * 500f);
                    rbR.AddForce(armVector * 500f);
                }
            }
            else
            {
                rbR.AddForce(armVector * 200f);
            }
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
            gameObject.GetComponent<Rigidbody2D>().mass = 5f;
            head.AddForce(armVector * 100f);
        }
        if(!leftGrabbing)
        {
            fjL.enabled = false;
            gameObject.GetComponent<Rigidbody2D>().mass = 9f;
        }

        if (cogR && rightGrabbing)
        {
            fjR.enabled = true;
            fjR.connectedBody = attachedRb;
            gameObject.GetComponent<Rigidbody2D>().mass = 5f;
        }
        if (!rightGrabbing)
        {
            fjR.enabled = false;
            gameObject.GetComponent<Rigidbody2D>().mass = 9f;
        }

        if (dead || hardReseting)
        {
            GamePad.SetVibration(playerIndex, 0.5f, 0.5f);
        }
        else
        {
            GamePad.SetVibration(playerIndex, 0f, 0f);
        }

        if (levelComplete)
        {
            string sceneName = currentScene.name;

            if(sceneName == "Level1")
            {
                if(selected == 1)
                {
                    SceneManager.LoadScene(3);
                }
            }

            if (sceneName == "Level2")
            {
                if (selected == 1)
                {
                    SceneManager.LoadScene(1);
                }
            }
        }

        Vector3.Lerp(rightWristPos, leftWrist.position, 1f);
        Vector3.Lerp(leftWristPos, transform.position, 1f);

        leftCanGrab = Physics2D.OverlapCircle(leftHand.transform.position, handRadius, WhatIsGrab); // Bool checks if the overlapsphere collides with layer mask for both hands
        rightCanGrab = Physics2D.OverlapCircle(rightHand.transform.position, handRadius, WhatIsGrab);
        grounded = Physics2D.OverlapCircle(head.transform.position, bodyRadius, WhatIsGrab);
        dead = Physics2D.OverlapCircle(head.transform.position, bodyRadius, WhatIsDeath);
        cogL = Physics2D.OverlapCircle(leftHand.transform.position, cogRadius, WhatIsCog);
        cogR = Physics2D.OverlapCircle(rightHand.transform.position, cogRadius, WhatIsCog);

    }

    private void OnTriggerEnter2D(Collider2D youWin)
    {
        if(youWin.gameObject.tag == "Goal")
        {
            _uiManager.ShowPopUp();
            _audioManager.Play("Level Complete");
            levelComplete = true;
        }
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

    private void HardReset()
    {
        hardReseting = true;
        StartCoroutine(_resetPlayer.Reset());
    }

    private void CancelReset()
    {
        hardReseting = false;
        StopCoroutine(_resetPlayer.Reset());
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
