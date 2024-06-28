using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkingHours : MonoBehaviour
{
    public MissionData missionData;
    public CurrencyManager currencyManager;
    public float timeGoal;
    public float time;
    public TMP_Text missionProgress;

    private void Update() {
        time += Time.deltaTime/3600;
        if(missionData.isCompleted == 0) {
            missionProgress.text = (int)time + " / " + (int)timeGoal/3600;
            if(time >= timeGoal) {
                missionData.isCompleted = 1;
                currencyManager.currentMoney += 5000000;
            }
        }
        else if(missionData.isCompleted == 1) {
            missionProgress.text = "Completed!";
        }
    }
}
