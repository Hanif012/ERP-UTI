using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject[] tabs;
    public Button[] buttons;

    private bool isTab = false;


    void Start()
    {
        closeall();
    }
    public void tab1()
    {
        if(isTab)
        {
            tabs[0].gameObject.SetActive(false);
            isTab = false;
        }
        else
        {
            closeall();
            tabs[0].gameObject.SetActive(true);
            isTab = true;
        }
    }

    public void tab2()
    {
        if(isTab)
        {
            tabs[1].gameObject.SetActive(false);
            isTab = false;
        }
        else
        {
            closeall();
            tabs[1].gameObject.SetActive(true);
            isTab = true;
        }
    }

    public void tab3()
    {
        if(isTab)
        {
            tabs[2].gameObject.SetActive(false);
            isTab = false;
        }
        else
        {
            closeall();
            tabs[2].gameObject.SetActive(true);
            isTab = true;
        }
    }

    public void tab4()
    {
        if(isTab)
        {
            tabs[3].gameObject.SetActive(false);
            isTab = false;
        }
        else
        {
            closeall();
            tabs[3].gameObject.SetActive(true);
            isTab = true;
        }
    }

    public void setting(){

        if(isTab)
        {
            tabs[4].gameObject.SetActive(false);
            isTab = false;
        }
        else
        {
            closeall();
            tabs[4].gameObject.SetActive(true);
            isTab = true;
        }
    
    }

    public void closeall()
    {
        for(int i=0; i<tabs.Length; i++)
        {
            tabs[i].gameObject.SetActive(false);
        }
    }
}
