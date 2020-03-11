using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grab : MonoBehaviour
{
    [SerializeField] private Controls _controls; // Input acrion set
    private Rigidbody2D rbR, rbL; // Left and Right hand rigidbodies
    private Hands _hands; // References hands script

    public Sprite open, closed; // Images for the open and closed claws
    public GameObject left, right; // Both hands
   

    private void Awake()
    {
        _controls = new Controls();
        _hands = FindObjectOfType<Hands>(); // Finds objects in the scene with the hands script attached

        rbL = left.GetComponent<Rigidbody2D>(); 
        rbR = right.GetComponent<Rigidbody2D>();
    }

    private void OnEnable() // Called when a button is pushed on the controller
    {
        _controls.Player.Enable();
        // Pressed Actions
        _controls.Player.LeftHand.performed += ctx => LeftClose(); 
        _controls.Player.RightHand.performed += ctx => RightClose();

        // Release Actions
        _controls.Player.LeftHand.canceled += ctx => LeftOpen();
        _controls.Player.RightHand.canceled += ctx => RightOpen();
    }

    private void OnDisable()
    {
        _controls.Player.Disable();
    }

    // Closes the playes hand and locks the rigid body in place
    private void LeftClose()
    {
        left.GetComponent<SpriteRenderer>().sprite = closed;

        if (_hands.leftCanGrab)
        {
            rbL.bodyType = RigidbodyType2D.Static;
            _hands.head.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void RightClose()
    {
        right.GetComponent<SpriteRenderer>().sprite = closed;

        if (_hands.rightCanGrab)
        {
            rbR.bodyType = RigidbodyType2D.Static;
            _hands.head.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    // Opens the players hand and allows the rigid body to move again
    private void LeftOpen()
    {
        left.GetComponent<SpriteRenderer>().sprite = open;

        if(rbL.bodyType == RigidbodyType2D.Static)
        {
            rbL.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void RightOpen()
    {
        right.GetComponent<SpriteRenderer>().sprite = open;

        if (rbR.bodyType == RigidbodyType2D.Static)
        {
            rbR.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
