using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelIntro : MonoBehaviour
{
    public LeanTweenType easeType;
    public AnimationCurve curve;
    public float duration, delay;
    public GameObject cam;
    public bool playerDrop;
    private Scene currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    void OnEnable()
    {
        string sceneName = currentScene.name;

        if (sceneName == "Level1")
        {
            Debug.Log("hell yeah");
        }

        if (easeType == LeanTweenType.animationCurve)
        {
            LeanTween.move(cam, new Vector3(0.81f, -0.19f, -4), 4);
        }
    }

    private void Update()
    {
       
    }
}
