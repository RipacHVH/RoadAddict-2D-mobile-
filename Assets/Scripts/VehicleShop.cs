using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehicleShop : MonoBehaviour
{
    int JeepCarPrice = 5000;
    public static bool JeepBought = false;

    public static bool defaultCarSelected = true;

    public static bool jeepCarSelected = false;
    public static bool jeepCarPurchased = false;

    public GameObject DCarSelect;
    public GameObject DCarSelected;

    public GameObject JCarSelect;
    public GameObject JCarSelected;
    public GameObject JCarPurchase;
    public Image JeepCarPriceCoin;

    public Text JeepCarPriceText;


    void Start()
    {
        ButtonCheck();
    }

    void Update()
    {
        JeepCarPriceText.text = JeepCarPrice.ToString();
    }

    public void SelectDefaultCar()
    {
        PlayerStats.CarNumber = 1;
        PlayerStats.defaultCarSelected = true;
        PlayerStats.jeepCarSelected = false;
        ButtonCheck();
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void BuyJeepCar()
    {

        if (!PlayerStats.JeepBought && PlayerStats.Money >= JeepCarPrice)
        {
            PlayerStats.Money -= JeepCarPrice;
            PlayerStats.CarNumber = 2;
            PlayerStats.JeepBought = true;
            PlayerStats.jeepCarPurchased = true;

            PlayerStats.jeepCarSelected = true;
            PlayerStats.defaultCarSelected = false;
            JeepCarPriceText.enabled = false;
            JeepCarPriceCoin.enabled = false;

            ButtonCheck();
            GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
        }
        if (PlayerStats.JeepBought)
        {
            PlayerStats.CarNumber = 2;
            PlayerStats.jeepCarSelected = true;
            PlayerStats.defaultCarSelected = false;
            ButtonCheck();
            GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
        }

    }

    void ButtonCheck()
    {
        if (PlayerStats.jeepCarPurchased)
        {
            JeepCarPriceText.enabled = false;
            JeepCarPriceCoin.enabled = false;
            JCarPurchase.SetActive(false);
            if (PlayerStats.jeepCarSelected)
            {
                JCarSelect.SetActive(false);
                JCarSelected.SetActive(true);
                JCarPurchase.SetActive(false);
            }
        }
        if (!PlayerStats.jeepCarPurchased)
        {
            JCarPurchase.SetActive(true);
            JCarSelect.SetActive(false);
            JCarSelected.SetActive(false);
        }
       
        if (!PlayerStats.jeepCarSelected && PlayerStats.jeepCarPurchased)
        {
            JCarSelect.SetActive(true);
        }




        //Default Car
        if (PlayerStats.defaultCarSelected)
        {
            DCarSelected.SetActive(true);
            DCarSelect.SetActive(false);
            JCarSelected.SetActive(false);
            if (PlayerStats.jeepCarPurchased)
            {
                JCarSelect.SetActive(true);
            }
            if(!PlayerStats.jeepCarPurchased)
            {
                JCarSelect.SetActive(false);
                JCarPurchase.SetActive(true);
            }
            
        }
        if (!PlayerStats.defaultCarSelected)
        {
            DCarSelected.SetActive(false);
            DCarSelect.SetActive(true);
        }

    }

}
