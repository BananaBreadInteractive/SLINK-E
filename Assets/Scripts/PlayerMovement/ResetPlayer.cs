using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class ResetPlayer : MonoBehaviour
{
    public Transform start;
    private Transform reset;
    private PlayerController player;

    private void Start()
    {
        reset = start;
        player = FindObjectOfType<PlayerController>();
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
        yield return new WaitForSeconds(1.5f);
        player.hardReseting = false;
        gameObject.transform.position = reset.position;
    }
}
