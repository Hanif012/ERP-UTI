using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
            // Debug.Log("AudioManager instance created");
        }

        else
        {
            Destroy(gameObject);
            // Debug.Log("An instance of AudioManager already exists");
        }
    }

    private void Start()
    {
        PlayMusic("BGM");
        AudioController.instance.LoadVolume();
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if(s == null)
        {
            Debug.Log("Sound not found: " + name);
        }

        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if(s == null)
        {
            Debug.Log("Sound not Found: " + name);
        }

        else
        {
            sfxSource.clip = s.clip;
            sfxSource.Play();
        }
    }

    public void ToggleMusic(bool mute)
    {
        musicSource.mute = mute;
    }

    public void ToggleSFX(bool mute)
    {
        sfxSource.mute = mute;
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }
}

