using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    private Vehicle vehicleData;
    private void Start()
    {
        vehicleData = gameObject.GetComponent<Vehicle>();
    }

    public void UpgradeVehicleProductionSpeed()
    {
        vehicleData.VehicleProduceSpeed *= 1;
    }

    public void UpgradeVehicleProductionAmount()
    {
        vehicleData.VehicleProduceAmount *= 1;
    }
}
