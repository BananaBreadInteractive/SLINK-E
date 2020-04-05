using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class MainMenu : MonoBehaviour
{
    private Controls _controls; //The player controlls
    public Transform selectionTransform1, selectionTransform2, selectionTransform3; // The positions of the cog indicator
    public GameObject indicator; // The cog indicator gameobject
    private Transform indicatorPos; // The position of the cog indicator
    private int selectionNumber = 1; //Represents which menu option is selected e.g. 1 = play, 2 = controls & 3 = exit game
    private float selected = 0; // Checks if the menu option has been selected/pressed

    public LineRenderer spring; //The spring between the bottom and top halves of the letter 'I'
    public GameObject top, bottom; // The bottom and top halves of the letter 'I'

    public Material playMat, controlMat, exitMat; // The three mennu options text materials
    private float glowVal = 0.3f; // The amount of glow on the menu options when selected

    private AudioManager _audioManager; // Audio manager component

    private void Awake()
    {
        _controls = new Controls();
    }

    private void Start()
    {
        indicatorPos = indicator.GetComponent<Transform>();
        indicatorPos.position = selectionTransform1.position;
        _audioManager = FindObjectOfType<AudioManager>();
    }

    //Listens for player inputs
    private void OnEnable()
    {
        _controls.Player.Enable();
        _controls.Player.DPadUp.started += ctx => Up();
        _controls.Player.DPadDown.started += ctx => Down();
        _controls.Player.Select.performed += ctx => selected = _controls.Player.Select.ReadValue<float>();
        _controls.Player.Select.canceled += ctx => selected = 0;

    }

    //Stop listening for player inputs
    private void OnDisable()
    {
        _controls.Player.Disable();
    }

    // Checks which menu option is selected and moves the inidicator to the correct position , makes the selected option glow and check if a menu optin was selected
    private void Update()
    {
        switch (selectionNumber)
        {
            case 0:
                indicatorPos.position = selectionTransform3.position;
                playMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                controlMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                exitMat.SetFloat(ShaderUtilities.ID_GlowPower, 0);
                selectionNumber = 3;
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

        if(selected == 1)
        {
            switch (selectionNumber)
            {
                case 1:
                    PlayGame();
                    break;
                case 2:
                    Controller();
                    break;
                case 3:
                    ExitGame();
                    break;
            }
        }

        //Sets the position of the spring inbetween the top half and bottom half of the letter 'I'
        spring.SetPosition(0, top.transform.localPosition);
        spring.SetPosition(1, bottom.transform.localPosition);
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

    //Changes scene to the demo
    public void PlayGame()
    {
        Debug.Log("Playing Game");
    }
    
    //Shoes the controller pop-up
    public void Controller()
    {
        Debug.Log("Showing Controls");
    }

    //Asks the player id they're sure about closing the game
    public void AreYouSure()
    {

    }

    //Closes application
    public void ExitGame()
    {
        
    }
}
