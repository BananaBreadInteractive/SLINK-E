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
    }
}
