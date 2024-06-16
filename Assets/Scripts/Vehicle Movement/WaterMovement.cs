using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    public WaterSpawner waterSpawner;
    private float speed = 10f;
    public GameObject Endpoint;
    
    private void Update() {
        if(waterSpawner.spawnedWater == null) {
            return;
        }
        if(Vector3.Distance(waterSpawner.spawnedWater.transform.position, Endpoint.transform.position) < 0.1f) {
            Destroy(waterSpawner.spawnedWater);
            waterSpawner.isWaterSpawned = false;
        }
        MoveCharacter();
    }

    public void MoveCharacter() {
        waterSpawner.spawnedWater.transform.position = Vector3.MoveTowards(waterSpawner.spawnedWater.transform.position, Endpoint.transform.position, speed * Time.deltaTime);
    }
}
