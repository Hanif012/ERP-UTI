using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public RocketSpawner rocketSpawner;
    private float speed = 10f;
    public GameObject Endpoint;

    private void Update() {
        if(rocketSpawner.spawnedRocket == null) {
            return;
        }
        if(Vector3.Distance(rocketSpawner.spawnedRocket.transform.position, Endpoint.transform.position) < 0.1f) {
            Destroy(rocketSpawner.spawnedRocket);
            rocketSpawner.isRocketSpawned = false;
        }
        MoveCharacter();
    }

    public void MoveCharacter() {
        rocketSpawner.spawnedRocket.transform.position = Vector3.MoveTowards(rocketSpawner.spawnedRocket.transform.position, Endpoint.transform.position, speed * Time.deltaTime);
    }
}
