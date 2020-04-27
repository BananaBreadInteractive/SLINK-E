using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour
{
    public GameObject player;


    private void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        player.transform.parent = null;
    }
}
