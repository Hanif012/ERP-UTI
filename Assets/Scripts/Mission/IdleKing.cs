using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IdleKing : MonoBehaviour
{
    public MissionData missionData;
    public CurrencyManager currencyManager;
    public int missionGoal;
    public TMP_Text missionProgress;

    private void Update() {
        float money = currencyManager.currentMoney;
        if(missionData.isCompleted == 0) {
            missionProgress.text = (int)money + " / " + missionGoal;
            if(money >= missionGoal) {
                missionData.isCompleted = 1;
                currencyManager.currentMoney += 1000000;
            }
        }
        else if(missionData.isCompleted == 1) {
            missionProgress.text = "Completed!";
        }   
    }

}
