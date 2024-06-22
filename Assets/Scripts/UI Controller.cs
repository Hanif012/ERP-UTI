using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject[] tabs;
    public Button[] buttons;

    // private bool isTab = false;


    void Start()
    {
        closeall();
    }
    public void tab1()
    {
        if(tabs[0].gameObject.activeSelf)
        {
            tabs[0].gameObject.SetActive(false);
        }
        else
        {
            closeall();
            tabs[0].gameObject.SetActive(true);
        }
        AudioManager.instance.PlaySFX("Click");
    }

    public void tab2()
    {
        if(tabs[1].gameObject.activeSelf)
        {
            tabs[1].gameObject.SetActive(false);
        }
        else
        {
            closeall();
            tabs[1].gameObject.SetActive(true);
        }
        AudioManager.instance.PlaySFX("Click");
    }

    public void tab3()
    {
        if(tabs[2].gameObject.activeSelf)
        {
            tabs[2].gameObject.SetActive(false);
        }
        else
        {
            closeall();
            tabs[2].gameObject.SetActive(true);
        }
        AudioManager.instance.PlaySFX("Click");
    }

    public void tab4()
    {
        if(tabs[3].gameObject.activeSelf)
        {
            tabs[3].gameObject.SetActive(false);
        }
        else
        {
            closeall();
            tabs[3].gameObject.SetActive(true);
        }
        AudioManager.instance.PlaySFX("Click");
    }

    public void setting(){

        if(tabs[4].gameObject.activeSelf)
        {
            tabs[4].gameObject.SetActive(false);
        }
        else
        {
            closeall();
            tabs[4].gameObject.SetActive(true);
        }
        AudioManager.instance.PlaySFX("Click");
    }

    public void closeall()
    {
        for(int i=0; i<tabs.Length; i++)
        {
            tabs[i].gameObject.SetActive(false);
        }
    }
}
