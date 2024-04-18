using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseManager : MonoBehaviour
{
    private Vehicle vehicleData;
    private CurrencyManager currencyManager;

    private void Start() {
        vehicleData = gameObject.GetComponent<Vehicle>();
        currencyManager = gameObject.GetComponent<CurrencyManager>();
    }

    public void Purchasing() {
        if(currencyManager.currentMoney >= vehicleData.VehiclePrice) {
            currencyManager.currentMoney -= vehicleData.VehiclePrice;
            vehicleData.IsBought = true;
        }
    }


}