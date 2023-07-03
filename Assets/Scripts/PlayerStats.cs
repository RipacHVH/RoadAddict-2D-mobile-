using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    //audio
    public static bool Muted = false;


    //Achievments
    public static int MaxScore = 0;


    //Vehicle Menu
    public static int CarNumber = 1;
    public static bool JeepBought = false;
    public static bool defaultCarSelected = true;
    public static bool jeepCarSelected = false;
    public static bool jeepCarPurchased = false;


    //LevelsSystem
    public static int levelReached = 1;










    //Upgrade Menu
    public static int Money = 0;
    public static int Hearts = 0;
    public static float speed = 1500f;
    public static int engineCost = 40;
    public static int turboCost = 10000;
    public static int rampsCost = 6000;
    public static int slowBallCost = 4000;
    public static int wheelsCost = 50;
    public static int earningsCost = 25;
    public static int Level = 0;
    public static int LevelWheels = 0;
    public static int LevelEarnings = 0;
    public static int LevelslowBall = 0;
    public static string Purchased = "Not Purchased";
    public static string PurchasedRamps = "Not Purchased";
    public static string redeemach1 = "Not Completed";
    public static string redeemach2 = "Not Completed";
    public static string redeemach3 = "Not Completed";
    public static string redeemach4 = "Not Completed";
    public static string redeemach5 = "Not Completed";
    public static string redeemach6 = "Not Completed";
    public static string redeemach7 = "Not Completed";
    public static string redeemach8 = "Not Completed";
    public static string redeemach9 = "Not Completed";
    public static string redeemach10 = "Not Completed";
    public static string redeemach11 = "Not Completed";
    public static string redeemach12 = "Not Completed";
    public static float friction = 1f;
    public static float CoinValue = 1f;
    public static int flips = 0;
    public static int InstantiateRamp = 0;

    public static bool isMaxedEngine = false;
    public static bool isMaxedWheels = false;
    public static bool isMaxedTurbo = false;
    public static bool isMaxedEarnings = false;
    public static bool isMaxedRamps = false;
    public static bool isMaxedSlowBall = false;

    public static bool isPurchased = false;
    public static bool redeemedach1 = false;
    public static bool redeemedach2 = false;
    public static bool redeemedach3 = false;
    public static bool redeemedach4 = false;
    public static bool redeemedach5 = false;
    public static bool redeemedach6 = false;
    public static bool redeemedach7 = false;
    public static bool redeemedach8 = false;
    public static bool redeemedach9 = false;
    public static bool redeemedach10 = false;
    public static bool redeemedach11 = false;
    public static bool redeemedach12 = false;

    private void Start()
    {
        LoadPlayer();
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);

    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();


        Muted = data.Muted;
        //fun
        MaxScore = data.MaxScore;


        //Vehicle System
        CarNumber = data.CarNumber;
        JeepBought = data.JeepBought;
        defaultCarSelected = data.defaultCarSelected;
        jeepCarSelected = data.jeepCarSelected;
        jeepCarPurchased = data.jeepCarPurchased;



        //levels system
        levelReached = data.levelReached;




        //upgrade menu
        speed = data.speed;
        Money = data.money;
        Hearts = data.hearts;
        engineCost = data.engineCost;
        turboCost = data.turboCost;
        rampsCost = data.rampsCost;
        slowBallCost = data.slowBallCost;
        wheelsCost = data.wheelsCost;
        earningsCost = data.earningsCost;
        Level = data.Level;
        LevelWheels = data.LevelWheels;
        LevelEarnings = data.LevelEarnings;
        LevelslowBall = data.LevelslowBall;

        Purchased = data.Purchased;
        InstantiateRamp = data.InstantiateRamp;
        
        redeemach1 = data.redeemach1;
        redeemach2 = data.redeemach2;
        redeemach3 = data.redeemach3;
        redeemach4 = data.redeemach4;
        redeemach5 = data.redeemach5;
        redeemach6 = data.redeemach6;
        

        flips = data.flips;
        CoinValue = data.CoinValue;
        friction = data.friction;

        isMaxedEngine = data.isMaxedEngine;
        isMaxedWheels = data.isMaxedWheels;
        isMaxedTurbo = data.isMaxedTurbo;
        isMaxedRamps = data.isMaxedRamps;
        isMaxedEarnings = data.isMaxedEarnings;
        isMaxedSlowBall = data.isMaxedSlowBall;


        isPurchased = data.isPurchased;
        
        redeemedach1 = data.redeemedach1;
        redeemedach2 = data.redeemedach2;
        redeemedach3 = data.redeemedach3;
        redeemedach4 = data.redeemedach4;
        redeemedach5 = data.redeemedach5;
        redeemedach6 = data.redeemedach6;
        redeemedach7 = data.redeemedach7;
        redeemedach8 = data.redeemedach8;
        redeemedach9 = data.redeemedach9;
        redeemedach10 = data.redeemedach10;
        redeemedach11 = data.redeemedach11;
        redeemedach12 = data.redeemedach12;


    }
    public void ResetSave()
    {
        SaveSystem.ResetSave();
        Application.Quit();
    }

}
