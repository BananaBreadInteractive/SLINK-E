using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grab : MonoBehaviour
{
    [SerializeField] private Controls _controls;
    public Sprite open, closed;
    public GameObject left, right;

    private void Awake()
    {
        _controls = new Controls();
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
    }

    private void LeftOpen()
    {
        left.GetComponent<SpriteRenderer>().sprite = open;
    }

    private void RightClose()
    {
        right.GetComponent<SpriteRenderer>().sprite = closed;
    }

    private void RightOpen()
    {
        right.GetComponent<SpriteRenderer>().sprite = open;
    }
}
