using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class MainMenu : MonoBehaviour
{
    private Controls _controls;
    public Transform selectionTransform1, selectionTransform2, selectionTransform3;
    public GameObject indicator;
    private Vector2 move;
    private Transform indicatorPos;
    private int selectionNumber = 1;

    public LineRenderer spring;
    public GameObject top, bottom;

    public GameObject text;
    public Material playMat, controlMat, exitMat;
    private float glowVal = 0.3f;

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
                controlMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                exitMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                playMat.SetFloat(ShaderUtilities.ID_GlowPower, glowVal);
                break;
            case 1:
                indicatorPos.position = selectionTransform1.position;
                controlMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                exitMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                playMat.SetFloat(ShaderUtilities.ID_GlowPower, glowVal);
                break;
            case 2:
                indicatorPos.position = selectionTransform2.position;
                playMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                exitMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                controlMat.SetFloat(ShaderUtilities.ID_GlowPower, glowVal);
                break;
            case 3:
                indicatorPos.position = selectionTransform3.position;
                playMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                controlMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                exitMat.SetFloat(ShaderUtilities.ID_GlowPower, glowVal);
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
