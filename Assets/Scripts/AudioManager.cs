using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach(Sound source in sounds)
        {
            source.audioSource = gameObject.AddComponent<AudioSource>();
            source.audioSource.clip = source.clip;

            source.audioSource.volume = source.volume;
            source.audioSource.pitch = source.pitch;
            source.audioSource.loop = source.loop;
        }
    }

    void Start()
    {
        Play("MainMusic");
    }

    public void Play(string name)
    {
        Sound currentSound = Array.Find(sounds, sound => sound.name == name);
        if (currentSound == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        currentSound.audioSource.Play();
    }
}
