using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour
{

    private Rigidbody2D rb;
    private Rigidbody2D cog;
    [SerializeField] private Vector2 cogVelocity;
    [SerializeField] private float cogAngularVelocity;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameObject.GetComponent<Rigidbody2D>() == true)
        {
            Destroy(rb);
        }
        if(Input.GetKeyDown(KeyCode.Space) && gameObject.GetComponent<Rigidbody2D>() == false)
        {
            gameObject.AddComponent<Rigidbody2D>();
            Rigidbody2D newRB2D = gameObject.GetComponent<Rigidbody2D>();

            if (cogVelocity != null)
            {
                newRB2D.velocity = cogVelocity;
            }

            if(cogAngularVelocity != 0)
            {
                newRB2D.angularVelocity = cogAngularVelocity;
            }
        }

        if(cog != null)
        {
            cogVelocity = cog.velocity;
            cogAngularVelocity = cog.angularVelocity;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "CogSprites")
       {
            transform.parent = collision.transform;
            cog = collision.gameObject.GetComponent<Rigidbody2D>();
       }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
