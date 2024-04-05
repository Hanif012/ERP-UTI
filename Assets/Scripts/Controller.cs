using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public TMP_Text currencyText;
    public GameData data;
    bool generatingMoney = true;
    public void Start() 
    {
        data = new GameData();
        
    }
    public void Update()
    {
        if(generatingMoney) {
            data.money += data.moneyPerSecond * Time.deltaTime;
        }
        currencyText.text = "Your Money: " + (int)data.money;
    }

}
