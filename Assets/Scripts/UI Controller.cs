using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] tabs;
    int index;
    void Start()
    {
        index = 0;
        tabs[0].gameObject.SetActive(true);
        tabs[1].gameObject.SetActive(false);
        tabs[2].gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(index >= 3)
        index = 3;

        if(index < 0)
        index = 0;
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
}
