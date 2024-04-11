using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
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
}
