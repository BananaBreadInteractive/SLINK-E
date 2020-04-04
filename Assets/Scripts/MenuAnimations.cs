using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAnimations : MonoBehaviour
{
    [SerializeField] private List<Transform> cogs;
    public bool clockwise, counterclockwise;
    private float rotSpeed = 10f;

    private void Start()
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("CogSprites"))
        {
            Transform cogTransforms = go.GetComponent<Transform>();
            cogs.Add(cogTransforms);
        }
    }

    private void Update()
    {
        
    }

}
