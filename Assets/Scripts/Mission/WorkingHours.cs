using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkingHours : MonoBehaviour
{
    public int isCompleted;
    public CurrencyManager currencyManager;
    public float timeGoal;
    public float time;
    public TMP_Text missionProgress;

    private void Update() {
        time += Time.deltaTime;
        if(isCompleted == 0) {
            missionProgress.text = (int)time + " / " + timeGoal;
            if(time >= timeGoal) {
                isCompleted = 1;
                currencyManager.currentMoney += 5000000;
            }
        }
        else if(isCompleted == 1) {
            missionProgress.text = "Completed!";
        }
    }
}
