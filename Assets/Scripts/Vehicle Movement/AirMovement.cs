using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirMovement : MonoBehaviour
{
    public AirSpawner airSpawner;
    private float speed = 5f;
    public GameObject Endpoint;
    
    private void Update() {
        if(airSpawner.spawnedAir == null) {
            return;
        }
        if(Vector3.Distance(airSpawner.spawnedAir.transform.position, Endpoint.transform.position) < 0.1f) {
            Destroy(airSpawner.spawnedAir);
            airSpawner.isAirSpawned = false;
        }
        MoveCharacter();
    }

    public void MoveCharacter() {
        airSpawner.spawnedAir.transform.position = Vector3.MoveTowards(airSpawner.spawnedAir.transform.position, Endpoint.transform.position, speed * Time.deltaTime);
    }
}
