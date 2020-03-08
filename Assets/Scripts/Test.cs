using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
   [SerializeField] private Controls _controls;
    private Vector2 arms;
    private Vector3 armPos;
    private float startTime;
    private float speed = 20f;
    private Rigidbody2D rb;

    private void Awake()
    {
        _controls = new Controls();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        armPos = transform.position;
        startTime = Time.time;
    }

    private void handleArms(InputAction.CallbackContext obj)
    {
        
    }

    void OnEnable()
    {
        _controls.Player.Enable();
        _controls.Player.Arms.performed += ctx => arms = ctx.ReadValue<Vector2>();
        _controls.Player.Arms.canceled += ctx => arms = Vector2.zero;
    }

    void OnDisable()
    {
        _controls.Player.Arms.performed -= handleArms;
        _controls.Player.Disable();
    }

    private void FixedUpdate()
    {
        //float distanceCovered = (Time.time - startTime) * speed;
        Vector2 myVector = new Vector2(arms.x, arms.y) * Time.deltaTime *speed;
        rb.MovePosition((Vector2) transform.position + (myVector));
        Vector3.Lerp(armPos, transform.position, 1f);
    }
}
