using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{
    public Controller controller;
    public GameData data;
    public double MotorBaseCost;
    public double MotorCostMult;

    public void Start()
    {
        MotorBaseCost = 10;
        MotorCostMult = 1.5;
    }
}