using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FirstStart : MonoBehaviour
{
    public MissionData missionData;
    public CurrencyManager currencyManager;
    public TMP_Text missionProgress;

    private void Update() {
        if(missionData.isCompleted == 0) {
            missionProgress.text = "000";
            missionData.isCompleted = 1;
            currencyManager.currentMoney += 100;
            
        }
        else if(missionData.isCompleted == 1) {
            missionProgress.text = "Completed!";
        }
    }
}
