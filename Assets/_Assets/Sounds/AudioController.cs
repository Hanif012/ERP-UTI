using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Toggle soundToggle, sfxToggle;
    public static AudioController instance;

    private void Awake() {
        instance = this;
        LoadVolume();
    }
    
    public void ToggleMusic()
    {
        AudioManager.instance.ToggleMusic(soundToggle.isOn);
        PlayerPrefs.SetInt("MusicMute", soundToggle.isOn ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void ToggleSFX()
    {
        AudioManager.instance.ToggleSFX(sfxToggle.isOn);
        PlayerPrefs.SetInt("SFXMute", sfxToggle.isOn ? 1 : 0);
        PlayerPrefs.Save();
    }
    
    public void LoadVolume()
    { 
        if(PlayerPrefs.GetInt("MusicMute") == 1)
        {
            soundToggle.isOn = true;
        }
        else
        {
            soundToggle.isOn = false;
        }

        if(PlayerPrefs.GetInt("SFXMute") == 1)
        {
            sfxToggle.isOn = true;
        }
        else
        {
            sfxToggle.isOn = false;
        }

        AudioManager.instance.ToggleMusic(soundToggle.isOn);
        AudioManager.instance.ToggleSFX(sfxToggle.isOn);   
    }
}
