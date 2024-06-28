using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeFlies : MonoBehaviour
{
    public MissionData missionData;
    public TimeCounter timeCounter;
    public CurrencyManager currencyManager;
    public float timeGoal;
    public TMP_Text timeProgress;

    private void Update() {
        float time = timeCounter.time / 3600;
        if(missionData.isCompleted == 0) {
            timeProgress.text = (int)time + " / " + (int)timeGoal / 3600;
            if(time >= timeGoal) {
                missionData.isCompleted = 1;
                currencyManager.currentMoney += 5000000;
            }
        }
        else if(missionData.isCompleted == 1) {
            timeProgress.text = "Completed!";
        }
    }
}
