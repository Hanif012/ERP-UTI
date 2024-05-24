using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    public CharacterSpawner characterSpawner;
    public GameObject point;
    public float character_speed = 0.01f;
    private int state = 0;
    private void Update() {
        float arrivalThreshold = 0.01f;
        if(state == 0){
            state = 1;
        }
        if(state == 1){
            if(Vector3.Distance(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position) < arrivalThreshold){
                state = 2;
            }
        }
        if(state == 2){
            if(Vector3.Distance(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position) < arrivalThreshold){
                Destroy(characterSpawner.spawnedCharacter);
                characterSpawner.isObjectSpawned = false;
            }
        }
        MoveCharacter(state);
    }

    void MoveCharacter(int pos) {
        float speed = character_speed * Time.deltaTime / 3;
        characterSpawner.spawnedCharacter.transform.position = Vector3.MoveTowards(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(pos).position, speed);
    }
}
    
