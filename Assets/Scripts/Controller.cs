using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public TMP_Text currencyText;
    public GameData data;

    public Darat.Motor motor;
    public Darat.Mobil mobil;
    public Darat.Bus bus;
    public Darat.Kereta kereta;

    public Upgrades.UpgradeMobil upgradeMobil;
    public Upgrades.UpgradeMotor upgradeMotor;
    public Upgrades.UpgradeBus upgradeBus;
    public Upgrades.UpgradeKereta upgradeKereta;
    
    public void Start() 
    {
        data = new GameData();
        motor = new Darat.Motor();
        mobil = new Darat.Mobil();
        bus = new Darat.Bus();
        kereta = new Darat.Kereta();
        
    }
    public void Update()
    {
        if(motor.bought) {
            data.money += motor.generate * Time.deltaTime;
        }
        if(mobil.bought) {
            data.money += mobil.generate * Time.deltaTime;
        }
        if(bus.bought) {
            data.money += bus.generate * Time.deltaTime;
        }
        if(kereta.bought) {
            data.money += kereta.generate * Time.deltaTime;
        }
        currencyText.text = "$" + (int)data.money;

    }



}
