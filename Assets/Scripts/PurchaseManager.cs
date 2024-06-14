using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PurchaseManager : MonoBehaviour
{
    private Vehicle vehicleData;
    private CurrencyManager currencyManager;
    public TMP_Text vehiclePriceText;

    private void Start() {
        vehicleData = gameObject.GetComponent<Vehicle>();
        currencyManager = FindObjectOfType<CurrencyManager>();
        vehiclePriceText.text = "$ " + vehicleData.VehiclePrice.ToString("F0");
    }

    private void Update() {
        if(vehicleData.IsBought == 1) {
            vehiclePriceText.text = "Bought";
        } else {
            vehiclePriceText.text = "Buy for $ " + vehicleData.VehiclePrice.ToString("F0");
        }
    }

    public void Purchasing() {
        if(currencyManager.currentMoney >= vehicleData.VehiclePrice && vehicleData.IsBought == 0) {
            currencyManager.currentMoney -= vehicleData.VehiclePrice;
            vehicleData.IsBought = 1;
            vehiclePriceText.text = "Bought";
        }
        AudioManager.instance.PlaySFX("Click");
    }


}
