using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Arms : MonoBehaviour
{
    [SerializeField] private Controls _controls;
    private Vector2 leftArm;
    private Vector3 armPos;
    private float startTime;
    private float speed = 8f;
    private Rigidbody2D rb;
    public Rigidbody2D player;

    private float radius = 0.3f;
    public LayerMask WhatIsGrab;
    public bool canGrab;

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

    void OnEnable()
    {
        _controls.Player.Enable();
        _controls.Player.Arms.performed += ctx => leftArm = ctx.ReadValue<Vector2>();
        _controls.Player.Arms.canceled += ctx => leftArm = Vector2.zero;

        _controls.Player.LeftHand.performed += ctx => Attatch();
        _controls.Player.RightHand.performed += ctx => Attatch();
        _controls.Player.LeftHand.canceled += ctx => Detatch();
        _controls.Player.RightHand.canceled += ctx => Detatch();
    }

    void OnDisable()
    {
        _controls.Player.Disable();
    }

    private void FixedUpdate()
    {
        Vector2 leftVector = new Vector2(leftArm.x, leftArm.y) * Time.deltaTime * speed;
        rb.MovePosition((Vector2)transform.position + (leftVector));
        Vector3.Lerp(armPos, transform.position, 1f);

        canGrab = Physics2D.OverlapCircle(transform.position, radius, WhatIsGrab);


    }

    void Attatch()
    {
        if (canGrab)
        {
            rb.bodyType = RigidbodyType2D.Static;
            player.bodyType = RigidbodyType2D.Dynamic;
        }

        
    }

    void Detatch()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
