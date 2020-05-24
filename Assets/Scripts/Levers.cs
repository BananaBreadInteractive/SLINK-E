using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour
{
    [SerializeField] private List<GameObject> levers;
    //public GameObject drawBridge;
    //private Animator anim;
    private MovingPlatform _movingPlatform;

    private void Start()
    {
        levers = new List<GameObject>();
        
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("Lever"))
        {
            levers.Add(go);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "LeverCheck")
        {
            if (collision.gameObject.name == "On")
            {
                Debug.Log("On");
            }

            else if (collision.gameObject.name == "Off")
            {
                Debug.Log("Off");
            }
        }
    }

}
