using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpawner : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject[] airData;
    public GameObject[] airVehicle;
    public GameObject spawnedAir;
    public bool isAirSpawned = false;
    private int airIndex = 0;

    void Update()
    {
        if(airIndex >= airData.Length) 
            airIndex = 0;
        
        if(!isAirSpawned){
            if(airData[airIndex].GetComponent<Vehicle>().IsBought == 1){
                SpawnAir(airVehicle[airIndex]);
                isAirSpawned = true;
            }
            airIndex++;
        }
        
    }

    public void SpawnAir(GameObject vehicle)
    { 
        spawnedAir = Instantiate(vehicle, spawnPoint.transform.position, Quaternion.identity);
    }
}
