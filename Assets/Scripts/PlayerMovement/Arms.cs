using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arms : MonoBehaviour // Draws a line renderer between players body and hands
{
    public Transform leftWrist, rightWrist;
    public Transform leftOrigin, rightOrigin;
    public LineRenderer leftSpring, rightSpring; //The arms of the player
    private Mesh leftMesh;
    private bool useTransform;

    private Vector3[] points;
    private Vector2[] pointsList;


    // Sets the position of the line renderer from the shoulders of the player to the start of the arms
    private void Update()
    { 

        leftSpring.SetPosition(0, leftOrigin.localPosition);
        leftSpring.SetPosition(1, leftWrist.localPosition);

        rightSpring.SetPosition(0, rightOrigin.localPosition);
        rightSpring.SetPosition(1, rightWrist.localPosition);

        
    }

}
