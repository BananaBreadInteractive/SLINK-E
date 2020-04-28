﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hands : MonoBehaviour // Moves the players hands in the direction of the left stick (and does a whole bunch of silly calculations)
{
    private _Grab grab;
    //public GameObject player;

    private void Start()
    {
        grab = FindObjectOfType<_Grab>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CogSprites")
        {
            if (grab.leftGrabbing || grab.rightGrabbing)
            {
                Debug.Log("collided");
                transform.parent = null;
                transform.parent = grab.leftHand;
                grab.leftHand.parent = collision.transform;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("bye");
        grab.leftHand.parent = null;
        grab.leftHand.parent = grab.leftWrist;
    }
}
