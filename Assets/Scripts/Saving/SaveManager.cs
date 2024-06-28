using System;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public CurrencyManager currencyManager;
    public GameObject VehicleData;
    public TimeCounter timeCounter;
    public GameObject missionData;

    private void Awake()
    {
        LoadData();
    }

    private void OnApplicationQuit() {
        SaveData();
    }

    private void OnApplicationPause() {
        SaveData();
    }

    public void SaveData() {
        SaveSystem.SavingData(currencyManager, VehicleData, timeCounter, missionData);
    }

    public void LoadData() {
        SaveData data = SaveSystem.LoadingData();
        if (data != null) {
            currencyManager.currentMoney = data.currency;
            timeCounter.time = data.time;
            int count = 0;
            for (int i=0; i<VehicleData.transform.childCount; i++) {
                for (int j=0; j<VehicleData.transform.GetChild(i).childCount; j++) {
                    VehicleData.transform.GetChild(i).GetChild(j).GetComponent<Vehicle>().IsBought = data.isBought[count];
                    count++;
                }
            }
        }
    }
}
