using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private Controls _controls; //Input Action Script
    private Vector2 arms; //The position of the the control stick that moves the players arms
    private Vector3 thingPos; // Position of the arms in the last frame
    private float speed = 8f; // Speed the player arms move
    private Rigidbody2D thingToMove;
    public Transform weightPos;

    private void Awake()
    {
        _controls = new Controls();
    }

    private void Start()
    {
       thingToMove = gameObject.GetComponent<Rigidbody2D>();
       thingPos = weightPos.position;
    }

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
        //thingToMove.MovePosition((Vector2)weightPos.position + (armVector));
        thingToMove.AddForce(armVector * 300f);
        Vector3.Lerp(thingPos, transform.position, 1f);
    }


}
