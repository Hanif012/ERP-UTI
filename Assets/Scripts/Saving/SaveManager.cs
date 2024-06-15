using System;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public CurrencyManager currencyManager;
    public GameObject VehicleData;

    private void Awake()
    {
        LoadData();
    }

    private void OnApplicationQuit() {
        SaveData();
    }

    public void SaveData() {
        SaveSystem.SavingData(currencyManager, VehicleData);
    }

    public void LoadData() {
        SaveData data = SaveSystem.LoadingData();
        if (data != null) {
            currencyManager.currentMoney = data.currency;
            int count = 0;
            for (int i=0; i<VehicleData.transform.childCount; i++) {
                for (int j=0; j<VehicleData.transform.GetChild(i).childCount; j++) {
                    VehicleData.transform.GetChild(i).GetChild(j).GetComponent<Vehicle>().IsBought = data.isBought[count];
                    print(data.isBought[count] + " " + count + " " + i + " " + j);
                    count++;
                }
            }
        }
    }
}
