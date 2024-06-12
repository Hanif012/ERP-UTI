using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;
    public bool musicMute, sfxMute;
    public static AudioController instance;

    private void Awake() {
        instance = this;
        LoadVolume();
    }
    
    public void ToggleMusic()
    {
        // Debug.Log(musicMute);
        AudioManager.instance.ToggleMusic(musicMute);
        if (musicMute) PlayerPrefs.SetInt("MusicMute", 1);
        else PlayerPrefs.SetInt("MusicMute", 0);
        musicMute = !musicMute;
    }

    public void ToggleSFX()
    {
        AudioManager.instance.ToggleSFX(sfxMute);
        if(sfxMute) PlayerPrefs.SetInt("SFXMute", 1);
        else PlayerPrefs.SetInt("SFXMute", 0);
        sfxMute = !sfxMute;
    }

    public void MusicVolume()
    {
        AudioManager.instance.MusicVolume(_musicSlider.value);
        PlayerPrefs.SetFloat("MusicVolume", _musicSlider.value);
    }

    public void SFXVolume()
    {
        AudioManager.instance.SFXVolume(_sfxSlider.value);
        PlayerPrefs.SetFloat("SFXVolume", _sfxSlider.value);
    }
    
    public void LoadVolume()
    {
        // Debug.Log(PlayerPrefs.GetInt("MusicMute"));
        _musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        _sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        AudioManager.instance.MusicVolume(_musicSlider.value);
        AudioManager.instance.SFXVolume(_sfxSlider.value);
        
        if(PlayerPrefs.GetInt("MusicMute") == 1)
        {
            musicMute = true;
        }
        else
        {
            musicMute = false;
        }

        if(PlayerPrefs.GetInt("SFXMute") == 1)
        {
            sfxMute = true;
        }
        else
        {
            sfxMute = false;
        }
        AudioManager.instance.ToggleMusic(musicMute);
        AudioManager.instance.ToggleSFX(sfxMute);
    }
}
