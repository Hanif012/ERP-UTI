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
    private float waitTime;
    private int state = 0;
    private bool isMoving = false;
    private void Start() {
        waitTime = 3f;
    }
    
    private void Update() {
        Debug.Log(" State : " + state);
        if(characterSpawner.spawnedCharacter == null) {
            return;
        }
        ManageState();
    }

    private void ManageState(){
        if(state == 0){
            MoveCharacter();
            if (Vector3.Distance(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position) < 0.1f){
                state = 1;
                waitTime = 3f;
            }
        }
        if(state == 1){
            MoveCharacter();
            if (Vector3.Distance(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position) < 0.1f) {
                if(waitTime > 0){
                    waitTime -= Time.deltaTime;
                }
                else{
                    state = 2;
                    waitTime = 3f;
                }
            }
        }
        if(state == 2){
            MoveCharacter();
            if (Vector3.Distance(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position) < 0.1f) {
                Destroy(characterSpawner.spawnedCharacter);
                characterSpawner.isObjectSpawned = false;
                ResetState();
            }
        }
    }

    void MoveCharacter() {
        float speed = character_speed * Time.deltaTime;
        characterSpawner.spawnedCharacter.transform.position = Vector3.MoveTowards(characterSpawner.spawnedCharacter.transform.position, point.transform.GetChild(state).position, speed);
    }

    void ResetState() {
        state = 0;
    }
    
}
    
