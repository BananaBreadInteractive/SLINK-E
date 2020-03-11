using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grab : MonoBehaviour
{
    [SerializeField] private Controls _controls;
    private Rigidbody2D rbR, rbL; // Left and Right hand rigidbodies
    private Arms _arms;

    public Sprite open, closed;
    public GameObject left, right;
   

    private void Awake()
    {
        _controls = new Controls();
        _arms = FindObjectOfType<Arms>();

        rbL = left.GetComponent<Rigidbody2D>();
        rbR = right.GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _controls.Player.Enable();
        _controls.Player.LeftHand.performed += ctx => LeftClose();
        _controls.Player.RightHand.performed += ctx => RightClose();

        _controls.Player.LeftHand.canceled += ctx => LeftOpen();
        _controls.Player.RightHand.canceled += ctx => RightOpen();
    }

    private void OnDisable()
    {
        _controls.Player.Disable();
    }

    private void LeftClose()
    {
        left.GetComponent<SpriteRenderer>().sprite = closed;

        if (_arms.leftCanGrab)
        {
            rbL.bodyType = RigidbodyType2D.Static;
            _arms.head.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void RightClose()
    {
        right.GetComponent<SpriteRenderer>().sprite = closed;

        if (_arms.rightCanGrab)
        {
            rbR.bodyType = RigidbodyType2D.Static;
            _arms.head.bodyType = RigidbodyType2D.Dynamic;
        }
    }

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

    private void Update()
    {
       
    }
}
