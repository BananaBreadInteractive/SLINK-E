using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public Transform start;
    private Transform reset;

    private void Start()
    {
        reset = start;
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
        gameObject.transform.position = reset.position;
    }
}
