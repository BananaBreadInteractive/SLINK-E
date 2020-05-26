using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    private AudioManager _audio;

    private void Start()
    {
        _audio = FindObjectOfType<AudioManager>();

        _audio.Play("Music");
        _audio.Play("Conveyors");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}
