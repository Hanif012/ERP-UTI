using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject Spawnpoint;
    public GameObject[] groundData;
    public GameObject[] groundVehicle;
    public GameObject spawnedGround;
    public bool isGroundSpawned = false;
    private int groundIndex = 0;

    void Update()
    {
        if(groundIndex >= groundData.Length) 
            groundIndex = 0;
        
        if(!isGroundSpawned){
            if(groundData[groundIndex].GetComponent<Vehicle>().IsBought == 1){
                SpawnGround(groundVehicle[groundIndex]);
                isGroundSpawned = true;
            }
            groundIndex++;
        }
        
    }

    public void SpawnGround(GameObject vehicle)
    { 
        spawnedGround = Instantiate(vehicle, Spawnpoint.transform.position, Quaternion.identity);
    }
}
