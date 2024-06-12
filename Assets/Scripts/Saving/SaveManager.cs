using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public CurrencyManager currencyManager;

    private void Start() {
        LoadData();
    }

    private void OnApplicationQuit() {
        SaveData();
    }

    private void SaveData() {
        for (int i=0; i<transform.childCount; i++) {
            for (int j=0; j<transform.GetChild(i).childCount; j++) {
                GameObject Vehicle = transform.GetChild(i).GetChild(j).gameObject;
                PlayerPrefs.SetInt(Vehicle.GetComponent<Vehicle>().VehicleName + "IsBought", Vehicle.GetComponent<Vehicle>().IsBought);
            }
        }
        PlayerPrefs.SetFloat("Currency", currencyManager.currentMoney);
    }
    
    private void LoadData() {
        for (int i=0; i<transform.childCount; i++) {
            for (int j=0; j < transform.GetChild(i).childCount; j++) {
                GameObject Vehicle = transform.GetChild(i).GetChild(j).gameObject;
                Vehicle.GetComponent<Vehicle>().IsBought = PlayerPrefs.GetInt(Vehicle.GetComponent<Vehicle>().VehicleName + "IsBought",0);
            }
        }
        currencyManager.currentMoney = PlayerPrefs.GetFloat("Currency", currencyManager.currentMoney);
    }

    
}
