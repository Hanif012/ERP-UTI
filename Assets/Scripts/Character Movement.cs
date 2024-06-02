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
    public float character_speed = 1f;
    private int state = 0;
    private bool isWaiting = false;

    private void Update() {
        if(characterSpawner.spawnedCharacter == null) {
            return;
        }
        ManageState();
        MoveCharacter();
    }

    private IEnumerator WaitAndIncrementState(){
        isWaiting = true;
        yield return new WaitForSeconds(3);
        state++;
        isWaiting = false;
    }

    private void ManageState() {
        float arrivalThreshold = 0.1f;

        Debug.Log(isWaiting);

        if(state >= point.transform.childCount) {
            state = 0;
        }
        if(state == 0){
            if(Vector3.Distance(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position) < arrivalThreshold){
                state = 1;
            }
        }
        if(state == 1){
            if(Vector3.Distance(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position) < arrivalThreshold){
                if (!isWaiting) {
                    StartCoroutine(WaitAndIncrementState());
                }
            }
        }
        if(state == 2){
            if(Vector3.Distance(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position) < arrivalThreshold){
                Destroy(characterSpawner.spawnedCharacter);
                characterSpawner.isObjectSpawned = false;
                characterSpawner.vehicleIndex++;
            }
        }
    }

    void MoveCharacter() {
        float speed = character_speed * Time.deltaTime / 3;
        characterSpawner.spawnedCharacter.transform.position = Vector3.MoveTowards(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position, speed);
    }

}
    
