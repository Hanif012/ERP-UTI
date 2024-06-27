using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    public float time;

    private void Update()
    {
        time += Time.deltaTime;
    }
}
