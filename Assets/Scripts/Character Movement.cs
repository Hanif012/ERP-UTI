using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    public CharacterSpawner characterSpawner;
    public GameObject point;
    public float character_speed = 2f;
    private void Update() {
        if(characterSpawner.spawnedCharacter == null) {
            return;
        }
        if(Vector3.Distance(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(2).position) < 0.1f) {
            Destroy(characterSpawner.spawnedCharacter);
            characterSpawner.isObjectSpawned = false;
        }
        MoveCharacter();
    }
    void MoveCharacter() {
        float speed = character_speed * Time.deltaTime;
        characterSpawner.spawnedCharacter.transform.position = Vector3.MoveTowards(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(2).position, speed);
    }
}
    
