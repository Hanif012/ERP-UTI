using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChanger : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject[] Position;
    public int positionIndex = 0;

    public void NextMap()
    {
        if(MainCam.transform.position == Position[positionIndex].transform.position)
        {
            positionIndex++;
            if(positionIndex >= Position.Length) 
                positionIndex = 0;
            MainCam.transform.position = Position[positionIndex].transform.position;
        }
    }

    public void PreviousMap()
    {
        if(MainCam.transform.position == Position[positionIndex].transform.position)
        {
            positionIndex--;
            if(positionIndex < 0) 
                positionIndex = Position.Length - 1;
            MainCam.transform.position = Position[positionIndex].transform.position;
        }
    }
}
