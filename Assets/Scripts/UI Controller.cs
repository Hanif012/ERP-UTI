using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;
    public GameObject[] tabs;
    public Button[] buttons;
    void Start()
    {
        for(int i=0; i<tabs.Length; i++)
        {
            tabs[i].gameObject.SetActive(false);
        }
    }
    public void tab1()
    {
        for(int i=0; i<tabs.Length; i++)
        {
            tabs[i].gameObject.SetActive(false);
            tabs[0].gameObject.SetActive(true);
        }
    }

    public void tab2()
    {
        for(int i=0; i<tabs.Length; i++)
        {
            tabs[i].gameObject.SetActive(false);
            tabs[1].gameObject.SetActive(true);

        }
    }

    public void tab3()
    {
        for(int i=0; i<tabs.Length; i++)
        {
            tabs[i].gameObject.SetActive(false);
            tabs[2].gameObject.SetActive(true);

        }
    }

    public void tab4()
    {
        for(int i=0; i<tabs.Length; i++)
        {
            tabs[i].gameObject.SetActive(false);
            tabs[3].gameObject.SetActive(true);

        }
    }

    public void closeall()
    {
        for(int i=0; i<tabs.Length; i++)
        {
            tabs[i].gameObject.SetActive(false);
        }
    }

    public void ToggleMusic()
    {
        AudioManager.instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        AudioManager.instance.ToggleSFX();
    }

    public void MusicVolume()
    {
        AudioManager.instance.MusicVolume(_musicSlider.value);
    }

    public void SFXVolume()
    {
        AudioManager.instance.SFXVolume(_sfxSlider.value);
    }
    
}
