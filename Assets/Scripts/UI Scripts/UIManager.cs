using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject completePopUp, bg, pauseMenu, indicator;
    private PlayerController player;
    private Controls _controls;
    public bool hardReseting;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        completePopUp.transform.localScale = new Vector3(0, 0, 0);
        Time.timeScale = 1;
    }

    public void ShowPopUp()
    {
        bg.SetActive(true);
        LeanTween.scale(completePopUp, new Vector3(1, 1, 1), 0.8f);
        player.enabled = false;
    }

    public void ShowPause()
    {
        bg.SetActive(true);
        pauseMenu.SetActive(true);
        indicator.SetActive(true);
        player.enabled = false;
        Time.timeScale = 0;
    }

    public void HidePause()
    {
        bg.SetActive(false);
        pauseMenu.SetActive(false);
        indicator.SetActive(false);
        player.enabled = (true);
        Time.timeScale = 1;
    }
}
