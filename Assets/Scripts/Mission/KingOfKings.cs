using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KingOfKings : MonoBehaviour
{
    public GameObject vehicleData;
    public CurrencyManager currencyManager;
    public int isCompleted;
    public int missionGoal;
    public TMP_Text missionProgress;

    private void Update() {
        int count = 0;
        for (int i=0; i<vehicleData.transform.childCount; i++) {
            for(int j=0; j<vehicleData.transform.GetChild(i).childCount; j++) {
                if(vehicleData.transform.GetChild(i).GetChild(j).GetComponent<Vehicle>().IsBought == 1) count++;
            }
        }
        if(isCompleted == 0) {
            missionProgress.text = count + " / " + missionGoal;
            if(count >= missionGoal) {
                isCompleted = 1;
                currencyManager.currentMoney += 250000;
            }
        }
        else if(isCompleted == 1) {
            missionProgress.text = "Completed!";
        }
    }
}
