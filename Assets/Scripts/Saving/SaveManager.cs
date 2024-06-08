using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public CurrencyManager currencyManager;
    public Vehicle BikeData;
    public Vehicle CarData;
    public Vehicle BusData;
    public Vehicle TrainData;

    private void Start() {
        LoadData();
    }

    private void Update() {
        BikeData = GameObject.Find("Bike").GetComponent<Vehicle>();
        CarData = GameObject.Find("Car").GetComponent<Vehicle>();
        BusData = GameObject.Find("Bus").GetComponent<Vehicle>();
        TrainData = GameObject.Find("Train").GetComponent<Vehicle>();
    }

    void SaveData(){
        PlayerPrefs.SetInt("BikeBought", BikeData.IsBought);
        PlayerPrefs.SetInt("CarBought", CarData.IsBought);
        PlayerPrefs.SetInt("BusBought", BusData.IsBought);
        PlayerPrefs.SetInt("TrainBought", TrainData.IsBought);

        PlayerPrefs.SetFloat("Money", (float)currencyManager.currentMoney);
    }

    void LoadData(){
        BikeData = PlayerPrefs.GetInt("BikeBought", 0) == 1 ? GameObject.Find("Bike").GetComponent<Vehicle>() : BikeData;
        CarData = PlayerPrefs.GetInt("CarBought", 0) == 1 ? GameObject.Find("Car").GetComponent<Vehicle>() : CarData;
        BusData = PlayerPrefs.GetInt("BusBought", 0) == 1 ? GameObject.Find("Bus").GetComponent<Vehicle>() : BusData;
        TrainData = PlayerPrefs.GetInt("TrainBought", 0) == 1 ? GameObject.Find("Train").GetComponent<Vehicle>() : TrainData;
        currencyManager.currentMoney = PlayerPrefs.GetFloat("Money", 100f);
    }

    private void OnApplicationQuit()
    {
        SaveData();
    }
}
