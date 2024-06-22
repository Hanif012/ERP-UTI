using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainSpawner : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject[] trainData;
    public GameObject[] trainVehicle;
    public GameObject spawnedTrain;
    public bool isTrainSpawned = false;
    private int trainIndex = 0;

    void Update()
    {
        if(trainIndex >= trainData.Length) 
            trainIndex = 0;
        
        if(!isTrainSpawned){
            if(trainData[trainIndex].GetComponent<Vehicle>().IsBought == 1){
                SpawnTrain(trainVehicle[trainIndex]);
                isTrainSpawned = true;
            }
            trainIndex++;
        }
        
    }

    public void SpawnTrain(GameObject vehicle)
    { 
        spawnedTrain = Instantiate(vehicle, spawnPoint.transform.position, Quaternion.identity);
    }
    
}
