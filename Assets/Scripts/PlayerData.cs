using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerData
{

    //audio
    public bool Muted;

    //fun
    public int MaxScore;

    //Vehicle System
    public int CarNumber;
    public bool JeepBought;
    public bool defaultCarSelected;
    public bool jeepCarSelected;
    public bool jeepCarPurchased;



    //LevelsSystem
    public int levelReached;









    //upgrade menu
    public int money;
    public int hearts;
    public float speed;
    public int engineCost;
    public int turboCost;
    public int rampsCost;
    public int slowBallCost;
    public int wheelsCost;
    public int earningsCost;



    public int Level;
    public int LevelWheels;
    public int LevelEarnings;
    public int LevelslowBall;
    public int InstantiateRamp;

    public string Purchased;
    
    public string redeemach1;
    public string redeemach2;
    public string redeemach3;
    public string redeemach4;
    public string redeemach5;
    public string redeemach6;
    public string redeemach7;
    public string redeemach8;
    public string redeemach9;
    public string redeemach10;
    public string redeemach11;
    public string redeemach12;

    public float CoinValue;
    public float friction;
    public int flips;


    public bool isMaxedEngine;
    public bool isMaxedWheels;
    public bool isMaxedTurbo;
    public bool isMaxedRamps;
    public bool isMaxedEarnings;
    public bool isMaxedSlowBall;

    public bool isPurchased;

    public bool redeemedach1;
    public bool redeemedach2;
    public bool redeemedach3;
    public bool redeemedach4;
    public bool redeemedach5;
    public bool redeemedach6;
    public bool redeemedach7;
    public bool redeemedach8;
    public bool redeemedach9;
    public bool redeemedach10;
    public bool redeemedach11;
    public bool redeemedach12;


    public PlayerData (PlayerStats player)
    {
        Muted = PlayerStats.Muted;

        //fun
        MaxScore = PlayerStats.MaxScore;



        //Vehicle System
        CarNumber = PlayerStats.CarNumber;
        JeepBought = PlayerStats.JeepBought;
        defaultCarSelected = PlayerStats.defaultCarSelected;
        jeepCarSelected = PlayerStats.jeepCarSelected;
        jeepCarPurchased = PlayerStats.jeepCarPurchased;

    //levels system
    levelReached = PlayerStats.levelReached;








        //upgrade menu
        money = PlayerStats.Money;
        hearts = PlayerStats.Hearts;
        speed = PlayerStats.speed;
        engineCost = PlayerStats.engineCost;
        turboCost = PlayerStats.turboCost;
        rampsCost = PlayerStats.rampsCost;
        slowBallCost = PlayerStats.slowBallCost;
        wheelsCost = PlayerStats.wheelsCost;
        earningsCost = PlayerStats.earningsCost;


        Level = PlayerStats.Level;
        LevelWheels = PlayerStats.LevelWheels;
        LevelEarnings = PlayerStats.LevelEarnings;
        LevelslowBall = PlayerStats.LevelslowBall;


        Purchased = PlayerStats.Purchased;
        InstantiateRamp = PlayerStats.InstantiateRamp;
        
        redeemach1 = PlayerStats.redeemach1;
        redeemach2 = PlayerStats.redeemach2;
        redeemach3 = PlayerStats.redeemach3;
        redeemach4 = PlayerStats.redeemach4;
        redeemach5 = PlayerStats.redeemach5;
        redeemach6 = PlayerStats.redeemach6;
 
        CoinValue = PlayerStats.CoinValue;
        friction = PlayerStats.friction;
        flips = PlayerStats.flips;
        

        isMaxedEngine = PlayerStats.isMaxedEngine;
        isMaxedWheels = PlayerStats.isMaxedWheels;
        isMaxedTurbo = PlayerStats.isMaxedTurbo;
        isMaxedRamps = PlayerStats.isMaxedRamps;
        isMaxedEarnings = PlayerStats.isMaxedEarnings;
        InstantiateRamp = PlayerStats.InstantiateRamp;
        isPurchased = PlayerStats.isPurchased;
        isMaxedSlowBall = PlayerStats.isMaxedSlowBall;
        redeemedach1 = PlayerStats.redeemedach1;
        redeemedach2 = PlayerStats.redeemedach2;
        redeemedach3 = PlayerStats.redeemedach3;
        redeemedach4 = PlayerStats.redeemedach4;
        redeemedach5 = PlayerStats.redeemedach5;
        redeemedach6 = PlayerStats.redeemedach6;
        redeemedach7 = PlayerStats.redeemedach7;
        redeemedach8 = PlayerStats.redeemedach8;
        redeemedach9 = PlayerStats.redeemedach9;
        redeemedach10 = PlayerStats.redeemedach10;
        redeemedach11 = PlayerStats.redeemedach11;
        redeemedach12 = PlayerStats.redeemedach12;
    }
}
