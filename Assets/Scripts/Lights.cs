using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;


public class Lights : MonoBehaviour
{
    [SerializeField] private List<Light2D> myLights;
    float brightness;
    public float pointBrightness;
    public float freeformBrightness;

    private void Start()
    {
        myLights = new List<Light2D>();

        foreach (Light2D lights in GetComponentsInChildren<Light2D>())
        {
            myLights.Add(lights);
        }

        for (int i = 0; i < myLights.Count; i++)
        {
            if (myLights[i].lightType == Light2D.LightType.Point)
            {
                pointBrightness = myLights[i].intensity;
            }

            if (myLights[i].lightType == Light2D.LightType.Freeform)
            {
                freeformBrightness = myLights[i].intensity;
            }
        }
    }

    private void Update()
    {
       

        pointBrightness = Random.Range(10, 19);

    }
}
