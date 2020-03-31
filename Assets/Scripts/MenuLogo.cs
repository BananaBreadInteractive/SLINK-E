using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogo : MonoBehaviour
{
    public LineRenderer spring;
    public GameObject top, bottom;

    private void Update()
    {
        spring.SetPosition(0, top.transform.localPosition);
        spring.SetPosition(1, bottom.transform.localPosition);
    }
}
