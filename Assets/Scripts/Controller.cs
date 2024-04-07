using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public TMP_Text currencyText;
    public GameData data;
    bool MotorMoney = false;
    bool MobilMoney = false;
    bool BusMoney = false;
    bool KeretaMoney = false;
    public void Start() 
    {
        data = new GameData();
        
    }
    public void Update()
    {
        if(MotorMoney) {
            data.money += 1 * Time.deltaTime;
        }
        currencyText.text = "Your Money: " + (int)data.money;
    }

}
