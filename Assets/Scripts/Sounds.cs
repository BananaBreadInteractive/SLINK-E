using UnityEngine;
using UnityEngine.Audio;

//Defines the properties of a sound clip to be played
[System.Serializable]
public class Sounds
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
