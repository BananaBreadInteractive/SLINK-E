using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    private void Start()
    {
        gameObject.transform.localScale = new Vector3(0, 0, 0);
    }

    public void OnClose()
    {
        LeanTween.scale(gameObject, new Vector3(1, 1, 1), 1f).setOnComplete(DestroyMe);
    }

    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
