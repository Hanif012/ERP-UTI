using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeGod : MonoBehaviour
{
    public TimeCounter timeCounter;
    public CurrencyManager currencyManager;
    public int isCompleted;
    public float timeGoal;
    public TMP_Text timeProgress;

    private void Update() {
        float time = timeCounter.time;
        if(isCompleted == 0) {
            timeProgress.text = (int)time + " / " + timeGoal;
            if(time >= timeGoal) {
                isCompleted = 1;
                currencyManager.currentMoney += 1000000;
            }
        }
        else if(isCompleted == 1) {
            timeProgress.text = "Completed!";
        }
    }

}
