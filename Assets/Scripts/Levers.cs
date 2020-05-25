using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour
{
    public GameObject lever1, lever2, levers;
    public GameObject conveyor1, conveyor2;
    public GameObject platforms, bridge, flange;
    private GameObject cam;
    public GameObject virtualCamera;
    private MovingPlatform _movingPlatform;
    private MenuAnimations _menuAnimations;
    private AudioManager _audio;
    Rigidbody2D rb1, rb2;
    public bool drawbridgeActivated, platformsStopped, activated;

    public LeanTweenType easeType;
    public AnimationCurve curve;

    private void Start()
    {
        _movingPlatform = FindObjectOfType<MovingPlatform>();
        _menuAnimations = FindObjectOfType<MenuAnimations>();
        _audio = FindObjectOfType<AudioManager>();

        rb1 = lever1.GetComponent<Rigidbody2D>();
        rb2 = lever2.GetComponent<Rigidbody2D>();
        cam = Camera.main.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Left")
        {
            _audio.Play("Lever Clink 1");
            activated = false;
        }

        if (collision.gameObject.name == "Right")
        {
            _audio.Play("Lever Clink 2");
            activated = true;
        }

        if (collision.gameObject.tag == "LeverCheck")
        {
            if (this.gameObject == lever1)
            {
                if (activated)
                {
                    Activate();
                }
                else
                {
                    Deactivate();
                }
            }

            if(this.gameObject == lever2)
            {
                if (activated)
                {
                    virtualCamera.SetActive(false);
                    PanRight();
                }
            }
        }      
    }

    public void PanRight()
    { 
        Debug.Log("Paning to drawbridge");
        LeanTween.move(cam, new Vector3(18.7f, 23, -10), 2).setOnComplete(RaiseBridge).setEase(curve);
    }

    public void RaiseBridge()
    {
        HingeJoint2D hj2D = bridge.GetComponent<HingeJoint2D>();
        hj2D.useMotor = true;
        LeanTween.rotate(flange, new Vector3(0, 0, 90), 2.2f).setOnComplete(PanLeft).setEase(curve);
    }

    public void PanLeft()
    {
        Collider2D bridgeCollider = bridge.GetComponent<Collider2D>();
        bridgeCollider.isTrigger = false;
        LeanTween.move(cam, new Vector3(-38.6f, 23.2f, -10), 2).setOnComplete(RenableCam).setEase(curve);
    }

    public void RenableCam()
    { 
        virtualCamera.SetActive(true);
    }

    public void Deactivate()
    {
        
        _audio.sounds[7].volume = 0.2f;
        _audio.sounds[7].loop = true;

        foreach (MenuAnimations cogs in levers.GetComponentsInChildren<MenuAnimations>())
        {
            cogs.enabled = true;
        }

        foreach (SurfaceEffector2D belts in levers.GetComponentsInChildren<SurfaceEffector2D>())
        {
            belts.enabled = true;
            belts.gameObject.tag = "Untagged";
            belts.gameObject.layer = 0;
        }

        //foreach (MovingPlatform platforms in platforms.GetComponentsInChildren<MovingPlatform>())
        //{
        //    platforms.enabled = true;
        //}
    }


    public void Activate()
    {
        
        _audio.sounds[7].volume = 0;
        _audio.sounds[7].loop = false;

        foreach (MenuAnimations cogs in levers.GetComponentsInChildren<MenuAnimations>())
        {
            cogs.enabled = false;
        }

        foreach (SurfaceEffector2D belts in levers.GetComponentsInChildren<SurfaceEffector2D>())
        {
            belts.enabled = false;
            belts.gameObject.tag = "Grabbable";
            belts.gameObject.layer = 11;
        }

        //foreach (MovingPlatform platforms in platforms.GetComponentsInChildren<MovingPlatform>())
        //{
        //    platforms.enabled = false;
        //}
    }

    private void Update()
    {
       
    }
}