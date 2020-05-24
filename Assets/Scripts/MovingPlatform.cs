using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject platform;
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    private Vector3 nextPos;

    private void Start()
    {
        nextPos = startPos.position;
    }

    private void Update()
    {
        if(platform.transform.position.y == pos2.position.y)
        {
            nextPos = pos1.position;
        }

        if (platform.transform.position.y == pos1.position.y)
        {
            nextPos = pos2.position;
        }

        platform.transform.position = Vector3.MoveTowards(platform.transform.position, nextPos, speed * Time.deltaTime);
    }

}
