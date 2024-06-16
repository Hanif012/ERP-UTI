using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawner : MonoBehaviour
{
    public GameObject Spawnpoint;
    public GameObject[] waterData;
    public GameObject[] waterVehicle;
    public GameObject spawnedWater;
    public bool isWaterSpawned = false;
    private int waterIndex = 0;

    void Update()
    {
        if(waterIndex >= waterData.Length) 
            waterIndex = 0;
        
        if(!isWaterSpawned){
            if(waterData[waterIndex].GetComponent<Vehicle>().IsBought == 1){
                SpawnGround(waterVehicle[waterIndex]);
                isWaterSpawned = true;
            }
            waterIndex++;
        }
        
    }

    public void SpawnGround(GameObject vehicle)
    { 
        spawnedWater = Instantiate(vehicle, Spawnpoint.transform.position, Quaternion.identity);
    }
}
