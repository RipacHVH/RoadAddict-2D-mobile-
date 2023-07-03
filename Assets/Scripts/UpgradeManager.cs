using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{


    public static int engineCost = 40;
    public static int turboCost = 10000;
    public static int slowBallCost = 4000;
    public static int wheelsCost = 50;
    public static int earningsCost = 25;
    public static int rampsCost = 6000;


    public static int Level = 0;
    public static int LevelWheels = 0;
    public static int LevelEarnings = 0;
    public static int LevelslowBall = 0;
    public static int InstantiateRamp = 0;


    public static bool isMaxedEngine = false;
    public static bool isMaxedWheels = false;
    public static bool isMaxedTurbo = false;
    public static bool isMaxedRamps = false;
    public static bool isMaxedEarnings = false;
    public static bool isMaxedSlowBall = false;
    public static bool isPurchased = false;
    public static bool isPurchasedRamps = false;
    
    

    public static string Purchased = "Not Purchased";
    public static string PurchasedRamps = "Not Purchased";


    public GameObject upgradeAllMenu;
    public GameObject upgradeFreeplayMenu;
  
    
    


    public Text enginePriceText;
    public Text turboPriceText;
    public Text rampsPriceText;
    public Text slowBallPriceText;
    public Text wheelsPriceText;
    public Text earningsPriceText;
    
    public Text currentLevelsText;
    public Text purchesedText;
    public Text currentLevelRampsText;
    public Text currentLevelSlowBallText;
    public Text currentLevelWheelsText;
    public Text currentLevelEarningsText;
    
    

   

    private void Update()
    {
        isMaxedEngine = PlayerStats.isMaxedEngine;
        isMaxedWheels = PlayerStats.isMaxedWheels;
        isMaxedTurbo = PlayerStats.isMaxedTurbo;
        isMaxedEarnings = PlayerStats.isMaxedEarnings;
        isMaxedRamps = PlayerStats.isMaxedRamps;
        isPurchased = PlayerStats.isPurchased;
        isMaxedSlowBall = PlayerStats.isMaxedSlowBall;
        


        enginePriceText.text = PlayerStats.engineCost.ToString();
        wheelsPriceText.text = PlayerStats.wheelsCost.ToString();
        turboPriceText.text = PlayerStats.turboCost.ToString();
        rampsPriceText.text = PlayerStats.rampsCost.ToString();
        slowBallPriceText.text = PlayerStats.slowBallCost.ToString();
        earningsPriceText.text = PlayerStats.earningsCost.ToString();
        currentLevelsText.text = PlayerStats.Level.ToString();
        currentLevelWheelsText.text = PlayerStats.LevelWheels.ToString();
        currentLevelEarningsText.text = PlayerStats.LevelEarnings.ToString();
        currentLevelRampsText.text = PlayerStats.InstantiateRamp.ToString();
        currentLevelSlowBallText.text = PlayerStats.LevelslowBall.ToString();



        purchesedText.text = PlayerStats.Purchased;

       if (chosemenuALL)
        {
            EngineIf();
            WheelsIf();
            if (PlayerStats.turboCost == 20000)
            {
                turboPriceText.text = "";
                GameObject.Find("TurboCoin").GetComponent<Image>().enabled = false;
            }
        }
       if (!chosemenuALL)
        {
            EarningsIf();
            RampsIf();
            SlowBallIf();
        }
        



    }
    bool chosemenuALL = true;
    public void ChooseMenuAll()
    {
        chosemenuALL = true;
        upgradeAllMenu.SetActive(true);
        upgradeFreeplayMenu.SetActive(false);
    }
    public void ChooseMenuFreeplay()
    {
        chosemenuALL = false;
        upgradeAllMenu.SetActive(false);
        upgradeFreeplayMenu.SetActive(true);
    }


    private void SlowBallIf()
    {
        RectTransform SBCoin = GameObject.Find("SBCoin").GetComponent<RectTransform>();
        RectTransform SBPrice = GameObject.Find("PriceSlowBall").GetComponent<RectTransform>();


        if (PlayerStats.slowBallCost == 32000)
        {
            SBPrice.anchoredPosition = new Vector3(0f, -150f, 0f);
            slowBallPriceText.text = "Maxed";
            GameObject.Find("SBCoin").GetComponent<Image>().enabled = false;
        }
        
        if (PlayerStats.slowBallCost >= 16000)
        {
            SBCoin.anchoredPosition = new Vector3(110, -150f, 0f);
        }
    }
    
    private void RampsIf()
    {
        RectTransform RampsCoin = GameObject.Find("RampsCoin").GetComponent<RectTransform>();
        RectTransform RampsPrice = GameObject.Find("PriceRamps").GetComponent<RectTransform>();



        if (PlayerStats.rampsCost > 24000)
        {
            RampsPrice.anchoredPosition = new Vector3(0f, -150f, 0f);
            rampsPriceText.text = "Maxed";
            GameObject.Find("RampsCoin").GetComponent<Image>().enabled = false;
        }
        
        
        if (PlayerStats.rampsCost >= 12000)
        {
            RampsCoin.anchoredPosition = new Vector3(110, -150f, 0f);
        }
    }
    private void EngineIf()
    {
        RectTransform EngineCoin = GameObject.Find("EngineCoin").GetComponent<RectTransform>();
        RectTransform EnginePrice = GameObject.Find("PriceEngine").GetComponent<RectTransform>();


        if (PlayerStats.engineCost == 40960)
        {
            EnginePrice.anchoredPosition = new Vector3(0f, -450f, 0f);
            enginePriceText.text = "Maxed";
            GameObject.Find("EngineCoin").GetComponent<Image>().enabled = false;
        }
        if (PlayerStats.engineCost >= 160)
        {
            EngineCoin.anchoredPosition = new Vector3(80f, -450f, 0f);
        }
        if (PlayerStats.engineCost >= 1280)
        {
            EngineCoin.anchoredPosition = new Vector3(100f, -450f, 0f);
        }
        if (PlayerStats.engineCost >= 10240)
        {
            EngineCoin.anchoredPosition = new Vector3(120, -450f, 0f);
        }
    }
    private void WheelsIf()
    {

        RectTransform WheelsCoin = GameObject.Find("WheelsCoin").GetComponent<RectTransform>();
        RectTransform WheelsPrice = GameObject.Find("PriceWheels").GetComponent<RectTransform>();
        


        if (PlayerStats.wheelsCost == 51200)
        {
            WheelsPrice.anchoredPosition = new Vector3(0f, -450, 0f);
            wheelsPriceText.text = "Maxed";
            GameObject.Find("WheelsCoin").GetComponent<Image>().enabled = false;
        }
        if (PlayerStats.wheelsCost >= 100)
        {
            WheelsCoin.anchoredPosition = new Vector3(89f, -150f, 0f);
        }
        if (PlayerStats.wheelsCost >= 1600)
        {
            WheelsCoin.anchoredPosition = new Vector3(109f, -150f, 0f);
        }
        if (PlayerStats.wheelsCost >= 12800)
        {
            WheelsCoin.anchoredPosition = new Vector3(129f, -150f, 0f);
        }
    }

    private void EarningsIf()
    {
        RectTransform earnCoin = GameObject.Find("EarningsCoin").GetComponent<RectTransform>();
        RectTransform earnPrice = GameObject.Find("PriceEarnings").GetComponent<RectTransform>();

        if (PlayerStats.earningsCost == 25600)
        {
            earnPrice.anchoredPosition = new Vector3(0f, -400f, 0f);
            earningsPriceText.text = "Maxed";
            GameObject.Find("EarningsCoin").GetComponent<Image>().enabled = false;
        }
        if(PlayerStats.earningsCost >= 100)
        {
            earnCoin.anchoredPosition = new Vector3(70f, -150f, 0f);
        }
        if (PlayerStats.earningsCost >= 1600)
        {
            earnCoin.anchoredPosition = new Vector3(90f, -150f, 0f);
        }
        if (PlayerStats.earningsCost >= 12800)
        {
            earnCoin.anchoredPosition = new Vector3(110f, -150f, 0f);
        }
    }
    public void UpgradeEarnings()
    {
        if (PlayerStats.Money >= PlayerStats.earningsCost)
        {
            PlayerStats.isMaxedEarnings = PlayerStats.LevelEarnings == 10;

            if (!PlayerStats.isMaxedEarnings)
            {
                PlayerStats.LevelEarnings += 1;
                PlayerStats.Money -= PlayerStats.earningsCost;
                PlayerStats.earningsCost += PlayerStats.earningsCost;

                PlayerStats.CoinValue += 0.5f;
                Debug.Log("Earnings Up!");

            }
            else
            {
                Debug.Log("You have already reached the highest earnings level");
            }
        }
        else
        {
            Debug.Log("Not enough money to Upgrade!");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }

    public void UpgradeWheels()
    {
        if (PlayerStats.Money >= PlayerStats.wheelsCost)
        {
            PlayerStats.isMaxedWheels = PlayerStats.LevelWheels == 10;

            if (!PlayerStats.isMaxedWheels)
            {
                PlayerStats.LevelWheels += 1;
                PlayerStats.Money -= PlayerStats.wheelsCost;
                PlayerStats.wheelsCost += PlayerStats.wheelsCost;

                PlayerStats.friction += 0.1f;
                Debug.Log("Friction up");

            }
            else
            {
                Debug.Log("You have already reached the highest wheels level");
            }
        }
        else
        {
            Debug.Log("Not enough money to Upgrade!");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }


    public void UpgradeEngine()
    {
        if (PlayerStats.Money >= PlayerStats.engineCost)
        {
            PlayerStats.isMaxedEngine = PlayerStats.Level == 10;

            if (!PlayerStats.isMaxedEngine)
            {
                PlayerStats.Level += 1;
                PlayerStats.Money -= PlayerStats.engineCost;
                PlayerStats.engineCost += PlayerStats.engineCost;

                PlayerStats.speed += 150;
                Debug.Log("Speed Up");
                
            }
            else
            {
                Debug.Log("You have already reached the highest engine level");
            }
        }
        else
        {
            Debug.Log("Not enough money to Upgrade!");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }

    public void UpgradeTurbo()
    {
        if (PlayerStats.Money >= PlayerStats.turboCost)
        {
            

            if (!PlayerStats.isPurchased)
            {
                PlayerStats.Money -= PlayerStats.turboCost;
                PlayerStats.turboCost += PlayerStats.turboCost;

                PlayerStats.Purchased = "Purchased";
                PlayerStats.isPurchased = true;
                PlayerStats.speed += 400;
                Debug.Log("You Have Purchased a Turbo");
                GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
            }
            else
            {
                Debug.Log("You have already Purchased a turbo");
            }
        }
        else
        {
            Debug.Log("Not enough money to Upgrade!");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }

    public void UpgradeRamps()
    {
        if (PlayerStats.Money >= PlayerStats.rampsCost)
        {

            PlayerStats.isMaxedRamps = PlayerStats.InstantiateRamp == 3;
            
            if (!PlayerStats.isMaxedRamps)
            {
                PlayerStats.InstantiateRamp += 1;
                PlayerStats.Money -= PlayerStats.rampsCost;
                PlayerStats.rampsCost += PlayerStats.rampsCost;

                PlayerStats.PurchasedRamps = "Purchased";
 

                Debug.Log("Ramps Activated");


                GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
            }
            else
            {
                Debug.Log("You have already Purchased 4x4");
            }
        }
        else
        {
            Debug.Log("Not enough money to Upgrade!");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void UpgradeslowBall()
    {
        if (PlayerStats.Money >= PlayerStats.slowBallCost)
        {
            PlayerStats.isMaxedSlowBall = PlayerStats.LevelslowBall == 3;

            if (!PlayerStats.isMaxedSlowBall)
            {
                PlayerStats.LevelslowBall += 1;
                PlayerStats.Money -= PlayerStats.slowBallCost;
                PlayerStats.slowBallCost += PlayerStats.slowBallCost;

                
                Debug.Log("slowball");
                Debug.Log(PlayerStats.slowBallCost);
            }
            else
            {
                Debug.Log("You have already reached the highest slowball level");
            }
        }
        else
        {
            Debug.Log("Not enough money to Upgrade!");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
}
