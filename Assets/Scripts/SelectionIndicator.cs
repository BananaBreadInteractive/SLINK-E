using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class SelectionIndicator : MonoBehaviour
{
    private Controls _controls;
    public Transform selectionTransform1, selectionTransform2, selectionTransform3;
    public GameObject indicator;
    private Vector2 move;
    private Transform indicatorPos;
    [SerializeField] private int selectionNumber = 0;

    public LineRenderer spring;
    public GameObject top, bottom;

    private void Awake()
    {
        _controls = new Controls();
    }

    private void Start()
    {
        indicatorPos = indicator.GetComponent<Transform>();
        indicatorPos.position = selectionTransform1.position;
    }

    private void OnEnable()
    {
        _controls.Player.Enable();
        _controls.Player.DPadUp.started += ctx => Up();
        _controls.Player.DPadDown.started += ctx => Down();

    }

    private void OnDisable()
    {
        _controls.Player.Disable();
    }


    private void Update()
    {
        switch (selectionNumber)
        {
            case 0:
                indicatorPos.position = selectionTransform1.position;
                break;
            case 1:
                indicatorPos.position = selectionTransform1.position;
                break;
            case 2:
                indicatorPos.position = selectionTransform2.position;
                break;
            case 3:
                indicatorPos.position = selectionTransform3.position;
                break;
            default:
                indicatorPos.position = selectionTransform1.position;
                selectionNumber = 1;
                break;
        }

        spring.SetPosition(0, top.transform.localPosition);
        spring.SetPosition(1, bottom.transform.localPosition);
    }

    public void Up()
    {
        selectionNumber--;
    }

    public void Down()
    {
        selectionNumber++;
    }

    public void PlayGame()
    {
        Debug.Log("3");
    }

    public void Controller()
    {

    }

}
