using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    // public TrainSpawner trainSpawner;
    // private float speed = 10f;
    // public GameObject Endpoint;
    
    // private void Update() {
    //     if(trainSpawner.spawnedTrain == null) {
    //         return;
    //     }
    //     if(Vector3.Distance(trainSpawner.spawnedTrain.transform.position, Endpoint.transform.position) < 0.1f) {
    //         Destroy(trainSpawner.spawnedTrain);
    //         trainSpawner.isTrainSpawned = false;
    //     }
    //     MoveCharacter();
    // }

    // public void MoveCharacter() {
    //     trainSpawner.spawnedTrain.transform.position = Vector3.MoveTowards(trainSpawner.spawnedTrain.transform.position, Endpoint.transform.position, speed * Time.deltaTime);
    // }
}
