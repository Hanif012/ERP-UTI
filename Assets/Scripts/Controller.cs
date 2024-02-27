using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public TMP_Text itemText;
    public TMP_Text upgradeText;
    public TMP_Text automateText;
    public TMP_Text speedText;
    public double multiplier = 1;
    public int cost_multiply = 10;
    public int cost_automate = 1000;
    public double items;
    public double timer_multiplier = 1;
    private bool automate = false;
    public void Update()
    {
        itemText.text = items + " Items";
        upgradeText.text = "x2 per Click , Cost : " + cost_multiply;
        if(automate == true)
        {
            if (Time.time % timer_multiplier < Time.deltaTime)
            {
                addItem();
            }
        }
    }
    
    public void addItem()
    {
        items += 1*multiplier; 
    }

    public void upgrade()
    {
        if(items < cost_multiply) return;
        items -= cost_multiply;
        multiplier *= 2;
        cost_multiply *= 10;

    }

    public void automateclick()
    {
        if(items >= 10000)
        {
            automate = true;
            upgradeText.text = "PURCHASED";
        }
    }

    public void automatemultiply()
    {
        if(items >= cost_automate)
        {
            timer_multiplier /= 1.5;
            cost_automate *= 10;
        }
    }

}
