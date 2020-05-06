using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAnimations : MonoBehaviour
{
    public bool clockwise, counterclockwise, big, small;
    private float rotSpeed;

    private void Start()
    {
        if (big)
        {
            rotSpeed = 2f;
        }
        else
        {
            rotSpeed = 5f;
        }
    }

    private void Update()
    {
       

        if (clockwise)
        {
            transform.Rotate(-Vector3.forward * rotSpeed);

            
        }

        if (counterclockwise)
        {
            transform.Rotate(Vector3.forward * rotSpeed);
        }
    }

}
