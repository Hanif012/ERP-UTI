using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MapChanger : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject[] Position;
    public int positionIndex = 0;

    private void onclick()
    {
        ChangeMap(positionIndex);
    }
    // change the map index 1 is land, 2 is sea, 3 is sky
    public void ChangeMap(int index)
    {
        if (index == 1)
        {
            MainCam.transform.position = new Vector3(Position[0].transform.position.x, Position[0].transform.position.y, MainCam.transform.position.z);
        }
        else if (index == 2)
        {
            MainCam.transform.position = new Vector3(Position[1].transform.position.x, Position[1].transform.position.y, MainCam.transform.position.z);
        }
        else if (index == 3)
        {
            MainCam.transform.position = new Vector3(Position[2].transform.position.x, Position[2].transform.position.y, MainCam.transform.position.z);
        }
    }
}
