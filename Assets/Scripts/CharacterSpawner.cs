using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject Spawnpoint;
    public GameObject[] vehicleData;
    public GameObject[] vehiclePrefab;
    private bool[] isBought;
    public int vehicleIndex = 0;
    public GameObject spawnedCharacter;
    public bool isObjectSpawned = false;

    void Start()
    {
        isBought = new bool[vehicleData.Length];
        for (int i = 0; i < vehicleData.Length; i++)
        {
            isBought[i] = vehicleData[i].GetComponent<Vehicle>().IsBought;
        }
    }
    void Update()
    {

        for (int i = 0; i < vehicleData.Length; i++)
        {
            isBought[i] = vehicleData[i].GetComponent<Vehicle>().IsBought;
        }

        if(vehicleIndex >= vehicleData.Length)
        {
            vehicleIndex = 0;
        }

        if(!isObjectSpawned){
            if(isBought[vehicleIndex]){
                SpawnVehicle(vehiclePrefab[vehicleIndex]);
                isObjectSpawned = true;
            }
            else{
                vehicleIndex++;
            }
        }
    }

    public void SpawnVehicle(GameObject vehicle)
    { 
        spawnedCharacter = Instantiate(vehicle, Spawnpoint.transform.position, Quaternion.identity);
    }
}
