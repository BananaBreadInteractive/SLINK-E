using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    private Controls _controls; //The player controlls
    public Transform resumePos, returnPos, indicatorPos; // The positions of the cog indicator
    public GameObject indicator; // The cog indicator gameobject
    private int selectionNumber = 1;
    private float selected = 0;
    private AudioManager _audioManager;
    private UIManager _uiManager;

    public Material resumeMat, returnMat;

    private void Awake()
    {
        _controls = new Controls();
    }

    private void Start()
    {
        indicatorPos = indicator.GetComponent<Transform>();
        indicatorPos.position = resumePos.position;
        _audioManager = FindObjectOfType<AudioManager>();
        _uiManager = FindObjectOfType<UIManager>();
    }

    //Listens for player inputs
    private void OnEnable()
    {
        _controls.Player.Enable();
        _controls.Player.DPadUp.started += ctx => Up();
        _controls.Player.DPadDown.started += ctx => Down();

        _controls.Player.Select.started += ctx => selected = _controls.Player.Select.ReadValue<float>();
        _controls.Player.Select.canceled += ctx => selected = 0;

        //_controls.Player.B.started += ctx => GoBack();

    }

    //Stop listening for player inputs
    private void OnDisable()
    {
        _controls.Player.Disable();
    }

    private void Update()
    {
        switch (selectionNumber)
        {
            case 0:
                indicatorPos.position = returnPos.position;
                selectionNumber = 2;
                break;
            case 1:
                indicatorPos.position = resumePos.position;
                resumeMat.SetFloat(ShaderUtilities.ID_GlowPower, 1);
                returnMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                break;
            case 2:
                indicatorPos.position = returnPos.position;
                resumeMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                returnMat.SetFloat(ShaderUtilities.ID_GlowPower, 1);
                break;
            case 3:
                indicatorPos.position = resumePos.position;
                selectionNumber = 1;
                break;
            default:
                indicatorPos.position = resumePos.position;
                selectionNumber = 1;
                break;
        }

        if (selected == 1)
        {
            switch (selectionNumber)
            {
                case 1:
                    _uiManager.HidePause();
                    break;
                case 2:
                    SceneManager.LoadScene(1);
                    break;
            }
        }
    }

    //Called when Up on the D-pad is pushed, decreases the selection button value and plays sound
    public void Up()
    {
        selectionNumber--;
        _audioManager.Play("MenuClick");
    }

    //Called when Down on the D-pad is pushed, increases the selection button value and plays sound
    public void Down()
    {
        selectionNumber++;
        _audioManager.Play("MenuClick");
    }
}
