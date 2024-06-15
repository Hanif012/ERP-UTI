using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData {
    public int[] isBought;
    public float currency;

    public SaveData(CurrencyManager currencyManager, GameObject VehicleData) {
        currency = currencyManager.currentMoney;
        Debug.Log(Application.persistentDataPath + "/saveData.save");
        isBought = new int[9];
        int count = 0;
        for (int i=0; i<VehicleData.transform.childCount; i++) {
            for (int j=0; j<VehicleData.transform.GetChild(i).childCount; j++) {
                isBought[count] = VehicleData.transform.GetChild(i).GetChild(j).GetComponent<Vehicle>().IsBought;
                count++;
            }
        }

    }
}
