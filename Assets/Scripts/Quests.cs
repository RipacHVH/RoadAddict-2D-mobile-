using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quests : MonoBehaviour
{
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


    public Text ach1flipsText;
    public Text ach2flipsText;
    public Text ach3flipsText;
    public Text ach4flipsText;
    public Text ach5flipsText;
    public Text ach6flipsText;

    public Text redeemach1Text;
    public Text redeemach2Text;
    public Text redeemach3Text;
    public Text redeemach4Text;
    public Text redeemach5Text;
    public Text redeemach6Text;
    public Text redeemach7Text;
    public Text redeemach8Text;
    public Text redeemach9Text;
    public Text redeemach10Text;
    public Text redeemach11Text;
    public Text redeemach12Text;





    private void Update()
    {
        redeemedach1 = PlayerStats.redeemedach1;
        redeemedach2 = PlayerStats.redeemedach2;
        redeemedach3 = PlayerStats.redeemedach3;
        redeemedach4 = PlayerStats.redeemedach4;
        redeemedach5 = PlayerStats.redeemedach5;
        redeemedach6 = PlayerStats.redeemedach6;
        redeemedach1 = PlayerStats.redeemedach7;
        redeemedach2 = PlayerStats.redeemedach8;
        redeemedach3 = PlayerStats.redeemedach9;
        redeemedach4 = PlayerStats.redeemedach10;
        redeemedach5 = PlayerStats.redeemedach11;
        redeemedach6 = PlayerStats.redeemedach12;

        ach1flipsText.text = PlayerStats.flips.ToString();
        ach2flipsText.text = PlayerStats.flips.ToString();
        ach3flipsText.text = PlayerStats.flips.ToString();
        ach4flipsText.text = PlayerStats.flips.ToString();
        ach5flipsText.text = PlayerStats.flips.ToString();
        ach6flipsText.text = PlayerStats.flips.ToString();


        redeemach1Text.text = PlayerStats.redeemach1;
        redeemach2Text.text = PlayerStats.redeemach2;
        redeemach3Text.text = PlayerStats.redeemach3;
        redeemach4Text.text = PlayerStats.redeemach4;
        redeemach5Text.text = PlayerStats.redeemach5;
        redeemach6Text.text = PlayerStats.redeemach6;
        redeemach7Text.text = PlayerStats.redeemach7;
        redeemach8Text.text = PlayerStats.redeemach8;
        redeemach9Text.text = PlayerStats.redeemach9;
        redeemach10Text.text = PlayerStats.redeemach10;
        redeemach11Text.text = PlayerStats.redeemach11;
        redeemach12Text.text = PlayerStats.redeemach12;
        if (PlayerStats.MaxScore >= 20000)
        {
            redeemach12Text.text = "redeem";
        }
        if (PlayerStats.redeemedach12)
        {
            redeemach12Text.text = "Completed";

        }
        if (PlayerStats.MaxScore >= 10000)
        {
            redeemach11Text.text = "redeem";
        }
        if (PlayerStats.redeemedach11)
        {
            redeemach11Text.text = "Completed";

        }
        if (PlayerStats.MaxScore >= 5000)
        {
            redeemach10Text.text = "redeem";
        }
        if (PlayerStats.redeemedach10)
        {
            redeemach10Text.text = "Completed";

        }
        if (PlayerStats.MaxScore >= 2000)
        {
            redeemach9Text.text = "redeem";
        }
        if (PlayerStats.redeemedach9)
        {
            redeemach9Text.text = "Completed";

        }

        if (PlayerStats.MaxScore >= 1000)
        {
            redeemach8Text.text = "redeem";
        }
        if (PlayerStats.redeemedach8)
        {
            redeemach8Text.text = "Completed";

        }

        if (PlayerStats.MaxScore >= 500)
        {
            redeemach7Text.text = "redeem";
        }
        if (PlayerStats.redeemedach7)
        {
            redeemach7Text.text = "Completed";

        }

        if (PlayerStats.flips >= 1000)
        {
            redeemach6Text.text = "redeem";
            ach6flipsText.text = "1000";
        }
        if (PlayerStats.redeemedach6)
        {
            redeemach6Text.text = "Completed";

        }

        if (PlayerStats.flips >= 200)
        {
            redeemach5Text.text = "redeem";
            ach5flipsText.text = "200";
        }
        if (PlayerStats.redeemedach5)
        {
            redeemach5Text.text = "Completed";

        }

        if (PlayerStats.flips >= 100)
        {
            redeemach4Text.text = "redeem";
            ach4flipsText.text = "100";
        }
        if (PlayerStats.redeemedach4)
        {
            redeemach4Text.text = "Completed";

        }

        if (PlayerStats.flips >= 50)
        {
            redeemach3Text.text = "redeem";
            ach3flipsText.text = "50";
        }
        if (PlayerStats.redeemedach3)
        {
            redeemach3Text.text = "Completed";

        }

        if (PlayerStats.flips >= 10)
        {
            redeemach2Text.text = "redeem";
            ach2flipsText.text = "10";
        }
        if (PlayerStats.redeemedach2)
        {
            redeemach2Text.text = "Completed";

        }

        if (PlayerStats.flips >= 5)
        {
            redeemach1Text.text = "redeem";
            ach1flipsText.text = "5";
        }
        if (PlayerStats.redeemedach1)
        {
            redeemach1Text.text = "Completed";
            
        }
    }
    public void Redeemedach12()
    {
        if (PlayerStats.MaxScore >= 20000 && !PlayerStats.redeemedach12)
        {

            PlayerStats.Money += 10000;
            PlayerStats.redeemedach12 = true;
        }
        if (PlayerStats.MaxScore >= 20000 && PlayerStats.redeemedach12)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not reached 20000 score   ");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void Redeemedach11()
    {
        if (PlayerStats.MaxScore >= 10000 && !PlayerStats.redeemedach11)
        {

            PlayerStats.Money += 5000;
            PlayerStats.redeemedach11 = true;
        }
        if (PlayerStats.MaxScore >= 10000 && PlayerStats.redeemedach11)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not reached 10000 score   ");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void Redeemedach10()
    {
        if (PlayerStats.MaxScore >= 5000 && !PlayerStats.redeemedach10)
        {

            PlayerStats.Money += 2500;
            PlayerStats.redeemedach10 = true;
        }
        if (PlayerStats.MaxScore >= 5000 && PlayerStats.redeemedach10)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not reached 5000 score   ");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void Redeemedach9()
    {
        if (PlayerStats.MaxScore >= 2000 && !PlayerStats.redeemedach9)
        {

            PlayerStats.Money += 1000;
            PlayerStats.redeemedach9 = true;
        }
        if (PlayerStats.MaxScore >= 2000 && PlayerStats.redeemedach9)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not reached 2000 score   ");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void Redeemedach8()
    {
        if (PlayerStats.MaxScore >= 1000 && !PlayerStats.redeemedach8)
        {

            PlayerStats.Money += 500;
            PlayerStats.redeemedach8 = true;
        }
        if (PlayerStats.MaxScore >= 1000 && PlayerStats.redeemedach8)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not reached 1000 score   ");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void Redeemedach7()
    {
        if (PlayerStats.MaxScore >= 500 && !PlayerStats.redeemedach7)
        {

            PlayerStats.Money += 100;
            PlayerStats.redeemedach7 = true;
        }
        if (PlayerStats.MaxScore >= 500 && PlayerStats.redeemedach7)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not reached 500 score   ");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void Redeemedach6()
    {
        if (PlayerStats.flips >= 1000 && !PlayerStats.redeemedach6)
        {

            PlayerStats.Money += 10000;
            PlayerStats.redeemedach6 = true;
        }
        if (PlayerStats.flips >= 1000 && PlayerStats.redeemedach6)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not made 1000 flips");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }

    public void Redeemedach5()
    {
        if (PlayerStats.flips >= 200 && !PlayerStats.redeemedach5)
        {

            PlayerStats.Money += 2000;
            PlayerStats.redeemedach5 = true;
        }
        if (PlayerStats.flips >= 200 && PlayerStats.redeemedach5)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not made 200 flips");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void Redeemedach4()
    {
        if (PlayerStats.flips >= 100 && !PlayerStats.redeemedach4)
        {

            PlayerStats.Money += 1000;
            PlayerStats.redeemedach4 = true;
        }
        if (PlayerStats.flips >= 100 && PlayerStats.redeemedach4)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not made 100 flips");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }

    public void Redeemedach3()
    {
        if (PlayerStats.flips >= 50 && !PlayerStats.redeemedach3)
        {

            PlayerStats.Money += 500;
            PlayerStats.redeemedach3 = true;
        }
        if (PlayerStats.flips >= 50 && PlayerStats.redeemedach3)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not made 50 flips");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }


    public void Redeemedach2()
    {
        if (PlayerStats.flips >= 10 && !PlayerStats.redeemedach2)
        {

            PlayerStats.Money += 100;
            PlayerStats.redeemedach2 = true;
        }
        if (PlayerStats.flips >= 10 && PlayerStats.redeemedach2)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not made 10 flips");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void Redeemedach1()
    {
        if (PlayerStats.flips >= 5 && !PlayerStats.redeemedach1)
        {

            PlayerStats.Money += 50;
            PlayerStats.redeemedach1 = true;
        }
        if(PlayerStats.flips >= 5 && PlayerStats.redeemedach1)
        {
            Debug.Log("You have already redeemed this quest");
        }
        else
        {
            Debug.Log("You have not made 5 flips");
        }
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }



}
