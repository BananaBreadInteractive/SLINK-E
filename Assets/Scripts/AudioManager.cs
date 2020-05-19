using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   public Sounds[] sounds; //Create a list of sounds for the sound class

    private void Awake()
    {
        foreach(Sounds s in sounds) //Give each item in the list the following properties
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    // Public function which plays the audio
    public void Play(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.name == name); //Lambda expression which finds the name of an audio clip from a string
        s.source.Play();
    }
}
