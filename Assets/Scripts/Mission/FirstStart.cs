using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FirstStart : MonoBehaviour
{
    public int isCompleted;
    public CurrencyManager currencyManager;
    public TMP_Text missionProgress;

    private void Update() {
        if(isCompleted == 0) {
            missionProgress.text = "000";
            isCompleted = 1;
            currencyManager.currentMoney += 100;
            
        }
        else if(isCompleted == 1) {
            missionProgress.text = "Completed!";
        }
    }
}
