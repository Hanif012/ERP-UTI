using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public TMP_Text currencyText;
    public GameData data;
    public void Start() 
    {
        data = new GameData();
    }
    public void Update()
    {
        currencyText.text = "Your Money: " + data.money;
    }
    
    public void Generate_Money()
    {
        data.money += 1;
    }

}
