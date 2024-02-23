using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public TMP_Text itemText;
    public TMP_Text upgradeText;
    public double multiplier = 1;
    public int cost = 10;
    public double items;
    public void Update()
    {
        itemText.text = items + " Items";
        upgradeText.text = "x2 per Click , Cost : " + cost;
    }
    
    public void addItem()
    {
        items += 1*multiplier; 
    }

    public void upgrade()
    {
        if(items < cost) return;
        items -= cost;
        multiplier *= 2;
        cost *= 10;

    }

}
