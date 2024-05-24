using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject Spawnpoint;
    public GameObject characterPrefab;
    public GameObject spawnedCharacter;
    public bool isObjectSpawned = false;
    void Start()
    {
        SpawnVehicle();
        isObjectSpawned = true;
    }
    void Update()
    {
        if(isObjectSpawned == false)
        {
            SpawnVehicle();
            isObjectSpawned = true;
        }
    }

    public void SpawnVehicle()
    {
        spawnedCharacter = Instantiate(characterPrefab, Spawnpoint.transform.position, Quaternion.identity);
    }
}
