using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject point;
    private enum State { pos1, pos2, pos3}
    private State currentState;
    private Dictionary<State, Vector3> points;
    void Start() {
        points = new Dictionary<State, Vector3>
        {
            { State.pos1, point.transform.GetChild(0).position },
            { State.pos2, point.transform.GetChild(1).position },
            { State.pos3, point.transform.GetChild(2).position }
        };
        currentState = State.pos1;

    }
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            switch (currentState)
            {
                case State.pos1:
                    currentState = State.pos2;
                    break;
                case State.pos2:
                    currentState = State.pos3;
                    break;
                case State.pos3:
                    currentState = State.pos1;
                    break;
            }

            MoveToPoint(points[currentState]);
        }
    }
    public void MoveToPoint(Vector3 point)
        {
            agent.SetDestination(point);
        }
}
