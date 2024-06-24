using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
    public GameObject Spawnpoint;
    public GameObject[] rocketData;
    public GameObject[] rocketVehicle;
    public GameObject spawnedRocket;
    public bool isRocketSpawned = false;
    private int rocketIndex = 0;

    void Update()
    {
        if(rocketIndex >= rocketData.Length) 
            rocketIndex = 0;
        
        if(!isRocketSpawned){
            if(rocketData[rocketIndex].GetComponent<Vehicle>().IsBought == 1){
                SpawnRocket(rocketVehicle[rocketIndex]);
                isRocketSpawned = true;
            }
            rocketIndex++;
        }
        
    }

    public void SpawnRocket(GameObject vehicle)
    { 
        spawnedRocket = Instantiate(vehicle, Spawnpoint.transform.position, Quaternion.identity);
    }
}
