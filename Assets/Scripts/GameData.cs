using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public double money;
    public double diamonds;

    public GameData()
    {
        money = 0;
        diamonds = 0;
    }

}

public class Darat
{
    public bool bought;
    public double price;
    public double generate;
    public double generatespeed;
    public class Motor : Darat
    {
        public Motor()
        {
            price = 10;
            generate = 1;
            generatespeed = 1;
            bought = false;
        }
    }

    public class Mobil : Darat
    {
        public Mobil()
        {
            price = 100;
            generate = 5;
            generatespeed = 1;
            bought = false;
        }
    }

    public class Bus : Darat
    {
        public Bus()
        {
            price = 1000;
            generate = 10;
            generatespeed = 1;
            bought = false;
        }
    }

    public class Kereta : Darat
    {
        public Kereta()
        {
            price = 10000;
            generate = 15;
            generatespeed = 1;
            bought = false;
        }
    }
}


