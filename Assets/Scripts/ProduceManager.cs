using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceManager : MonoBehaviour
{
    private Vehicle vehicleData;
    public CurrencyManager currencyManager;

    private void Start() {
        vehicleData = gameObject.GetComponent<Vehicle>();
    }

    private void Update() {
        if(vehicleData.IsBought) {
            currencyManager.currentMoney += vehicleData.VehicleProduceAmount * vehicleData.VehicleProduceSpeed * Time.deltaTime;
        }
    }

}
