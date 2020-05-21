using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class OpeningCutscene : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;

    private AudioManager _audioManager;

    private void Start()
    {
        _audioManager = FindObjectOfType<AudioManager>();
        StartCoroutine(PlayVideo());
        StartCoroutine(PlaySound());
        videoPlayer.loopPointReached += CheckOver;
        rawImage.color = new Color(1, 1, 1, 1); //set to 1,1,1,1 for version with video
    }

    IEnumerator PlaySound()
    {
        yield return new WaitForSeconds(2.8f);
        _audioManager.Play("Intro");
    }

    IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds wait = new WaitForSeconds(1f);
        while (!videoPlayer.isPrepared)
        {
            yield return wait;
            break;
        }

        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play(); 
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("Main Menu");
    }

}
