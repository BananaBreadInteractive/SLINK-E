using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAnimations : MonoBehaviour
{
    //[SerializeField] private List<Transform> cogs;  // Removed for prototype
    public bool clockwise, counterclockwise;
    private float rotSpeed = 10f;

    private void Start()
    {
        //foreach (GameObject go in GameObject.FindGameObjectsWithTag("CogSprites")) // Removed for prototype
        //{
        //    Transform cogTransforms = go.GetComponent<Transform>();
        //    cogs.Add(cogTransforms);
        //}
    }

    private void Update()
    {
        //for (int i = 0; i < cogs.Count; i++)
        //{

        //}

        if (clockwise)
        {
            transform.Rotate(-Vector3.forward);
        }

        if (counterclockwise)
        {
            transform.Rotate(Vector3.forward);
        }
    }

}
