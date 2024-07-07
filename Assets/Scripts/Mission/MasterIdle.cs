using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterIdle : MonoBehaviour
{
    public MissionData missionData;
    public CurrencyManager currencyManager;
    public float moneyGoal;
    public float money;
    public TMPro.TMP_Text missionProgress;

    private void Update() {
        money = currencyManager.currentMoney;
        if(missionData.isCompleted == 0) {
            missionProgress.text = (int)money + " / " + (int)moneyGoal;
            if(money >= moneyGoal) {
                missionData.isCompleted = 1;
                currencyManager.currentMoney += 100000000;
            }
        }
        else if(missionData.isCompleted == 1) {
            missionProgress.text = "Completed!";
        }
    }
}