using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hands : MonoBehaviour
{
    [SerializeField] private Controls _controls; //Input Action Script
    private Vector2 arms; //The position of the the control stick that moves the players arms
    private Vector3 leftHandPos, rightHandPos; // Position of the arms in the last frame
    private float speed = 8f; // Speed the player arms move
    private Rigidbody2D rbR, rbL; // Left and Right hand rigidbodies
    private float radius = 0.4f; // Radius of the hands overlap circle

    public Rigidbody2D head; // Rigidbody of the players head
    public Transform leftHand, rightHand; //References the position of the hands
    public LayerMask WhatIsGrab; // Layer mask to check what the player can grab 
    public bool leftCanGrab, rightCanGrab; // Checks to see if the players hands can grab a surface
    public bool grabbing; // Checks to see if the players hands can grab a surface

    private void Awake()
    {
        _controls = new Controls(); 
    }

    private void Start()
    {
        rbR = rightHand.GetComponent<Rigidbody2D>();
        rbL = leftHand.GetComponent<Rigidbody2D>();
        
        // Sets the position of the hand in the previous frame
        leftHandPos = leftHand.position;
        rightHandPos = rightHand.position;
    }

    // Listens for the inputs defined by the players input actions in the Controls class
    void OnEnable() 
    {
        _controls.Player.Enable();
        _controls.Player.Arms.performed += ctx => arms = ctx.ReadValue<Vector2>(); // Reads the value of the left stick as x and y values
        _controls.Player.Arms.canceled += ctx => arms = Vector2.zero; // Set the vector to zero when the stick is not being controlled
    }
    
    // Stops listening for Inputs when no buttons are being pressed
    void OnDisable()
    {
        _controls.Player.Disable();
    }

    // Moves the hands based on the position of the left stick and smooths the movement of the player
    private void FixedUpdate()
    {
        Vector2 armVector = new Vector2(arms.x, arms.y) * Time.deltaTime * speed;

        rbL.AddForce(armVector * 1000f);
        rbR.AddForce(armVector * 1000f);

        if(leftCanGrab || rightCanGrab)
        {
            head.AddForce(new Vector3(armVector.x, armVector.y * 3f, 0) * 180f);
        }
        

        Vector3.Lerp(rightHandPos, leftHand.position, 1f);
        Vector3.Lerp(leftHandPos, transform.position, 1f);

        leftCanGrab = Physics2D.OverlapCircle(leftHand.transform.position, radius, WhatIsGrab); // Bool checks if the overlapsphere collides with layer mask for both hands
        rightCanGrab = Physics2D.OverlapCircle(rightHand.transform.position, radius, WhatIsGrab);
    }

    // Draws a the overlap circle for each hand
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue; // Draws the left hand circle blue
        Gizmos.DrawWireSphere(leftHand.position, radius);
        Gizmos.color = Color.red;// Draws the right hand circle red
        Gizmos.DrawWireSphere(rightHand.position, radius);
    }
}
