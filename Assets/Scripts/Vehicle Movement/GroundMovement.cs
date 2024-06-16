using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public GroundSpawner groundSpawner;
    private float speed = 10f;
    public GameObject Endpoint;
    
    private void Update() {
        if(groundSpawner.spawnedGround == null) {
            return;
        }
        if(Vector3.Distance(groundSpawner.spawnedGround.transform.position, Endpoint.transform.position) < 0.1f) {
            Destroy(groundSpawner.spawnedGround);
            groundSpawner.isGroundSpawned = false;
        }
        MoveCharacter();
    }

    public void MoveCharacter() {
        groundSpawner.spawnedGround.transform.position = Vector3.MoveTowards(groundSpawner.spawnedGround.transform.position, Endpoint.transform.position, speed * Time.deltaTime);
    }
}
