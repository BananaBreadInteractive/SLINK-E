using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwoIntro : MonoBehaviour
{
    public GameObject vCam;

    private void Start()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            vCam.SetActive(true);
        }
    }
}
