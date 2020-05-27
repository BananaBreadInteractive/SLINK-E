using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class ResetPlayer1 : MonoBehaviour
{
    public Transform start;
    private Transform reset;
    private PlayerController1 player;
    public GameObject virtualCamera;  

    private void Start()
    {
        reset = start;
        player = FindObjectOfType<PlayerController1>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathFloor")
        {
            StartCoroutine(Reset());
        }
    }

    public IEnumerator Reset()
    {
        if (!player.leftGrabbing && !player.rightGrabbing)
        {
            virtualCamera.SetActive(false);
            yield return new WaitForSeconds(1.5f);
            player.hardReseting = false;
            gameObject.transform.position = reset.position;
            virtualCamera.SetActive(true);
        }
    }
}
