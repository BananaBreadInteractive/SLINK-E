using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject completePopUp, bg, pauseMenu, indicator;
    private PlayerController player;
    private PlayerController1 player1;
    private Controls _controls;
    public bool hardReseting;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        player1 = FindObjectOfType<PlayerController1>();
        completePopUp.transform.localScale = new Vector3(0, 0, 0);
        Time.timeScale = 1;
    }

    public void ShowPopUp()
    {
        bg.SetActive(true);
        LeanTween.scale(completePopUp, new Vector3(1, 1, 1), 0.8f);

        if (player != null)
        {
            player.enabled = false;
        }

        if (player1 != null)
        {
            player1.enabled = false;
        }

    }

    public void ShowPause()
    {
        if (player != null)
        {
            bg.SetActive(true);
            pauseMenu.SetActive(true);
            indicator.SetActive(true);
            player.enabled = false;
            Time.timeScale = 0;
        }

        if (player1 != null)
        {
            bg.SetActive(true);
            pauseMenu.SetActive(true);
            indicator.SetActive(true);
            player1.enabled = false;
            Time.timeScale = 0;
        }
    }

    public void HidePause()
    {
        if (player != null)
        {
            bg.SetActive(false);
            pauseMenu.SetActive(false);
            indicator.SetActive(false);
            player.enabled = (true);
            Time.timeScale = 1;
        }
        if (player1 != null)
        {
            bg.SetActive(false);
            pauseMenu.SetActive(false);
            indicator.SetActive(false);
            player1.enabled = (true);
            Time.timeScale = 1;
        }
    }
}
