using System.Collections;
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

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CogSprites")
        {
            grab.attachedRb = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        
    }
}
