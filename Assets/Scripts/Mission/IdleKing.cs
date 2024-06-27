using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IdleKing : MonoBehaviour
{
    public CurrencyManager currencyManager;
    public int isCompleted;
    public int missionGoal;
    public TMP_Text missionProgress;

    private void Update() {
        float money = currencyManager.currentMoney;
        if(isCompleted == 0) {
            missionProgress.text = (int)money + " / " + missionGoal;
            if(money >= missionGoal) {
                isCompleted = 1;
                currencyManager.currentMoney += 1000000;
            }
        }
        else if(isCompleted == 1) {
            missionProgress.text = "Completed!";
        }   
    }

}
