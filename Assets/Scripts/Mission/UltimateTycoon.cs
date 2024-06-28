using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UltimateTycoon : MonoBehaviour
{
    public MissionData missionData;
    public CurrencyManager currencyManager;
    public GameObject[] missionList;
    public TMP_Text missionProgress;

    private void Update() {
        int count = 0;
        if(missionData.isCompleted == 0) {
            missionProgress.text = count + " / " + missionList.Length;
            for(int i = 0; i < missionList.Length; i++) {
                if(missionList[i].GetComponent<MissionData>().isCompleted == 1) {
                    count++;
                }
            }
            if(count == missionList.Length) {
                missionData.isCompleted = 1;
                currencyManager.currentMoney += 1000000;
            }
        }
        else if(missionData.isCompleted == 1) {
            missionProgress.text = "Completed!";
        }
        
    }
}
