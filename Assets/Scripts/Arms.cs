using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arms : MonoBehaviour
{
    public Transform leftHand, rightHand;
    public Transform leftOrigin, rightOrigin;
    public LineRenderer leftSpring, rightSpring; //The arms of the player
    private Mesh leftMesh;
    private bool useTransform;


    void Start()
    {
        
    }

    // Sets the position of the line renderer from the shoulders of the player to the start of the arms
    private void Update()
    { 

        leftSpring.SetPosition(0, leftOrigin.localPosition);
        leftSpring.SetPosition(1, leftHand.localPosition);

        rightSpring.SetPosition(0, rightOrigin.localPosition);
        rightSpring.SetPosition(1, rightHand.localPosition);

        leftSpring.BakeMesh(leftMesh, useTransform = false);
    }

}
