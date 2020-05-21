using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hands : MonoBehaviour // Moves the players hands in the direction of the left stick (and does a whole bunch of silly calculations)
{
    private PlayerController player;
    private AudioManager _audioManager;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        _audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CogSprites")
        {
            player.attachedRb = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Grabbable" || collision.gameObject.tag == "CogSprites")
        {
            if(player.leftGrabbing && !player.rightGrabbing)
            {
                _audioManager.Play("Metal Clink 1");
            }

            if (player.rightGrabbing && !player.leftGrabbing)
            {
                _audioManager.Play("Metal Clink 2");
            }

            if(!player.leftGrabbing || !player.rightGrabbing)
            {
                _audioManager.Play("Metal Clink 2");
            }
        }
    }
}
