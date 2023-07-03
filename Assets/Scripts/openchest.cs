using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class openchest : MonoBehaviour
{
    int RewardNumber = 0;
    public Image RewardImage;
    public Image RewardImage2;
    public Image ChestClosed;
    public Image ChestOpened;
    public Sprite CoinsImage;
    public Text CoinReward;
    
    int highestCoinReward = 150;
    int lowestCoinReward = 80;
    int randomNumber;
    int moneyleft;
    int maxMoneyGiven;
    float addMoney;

    private void Start()
    {
        PauseMenu.AlreadyPaused = true;
        ChestOpened.enabled = false;
        ChestClosed.enabled = true;
        CoinReward.enabled = false;
        RewardImage2.color = new Color(RewardImage.color.r, RewardImage.color.g, RewardImage.color.b, 0f);
        RewardImage.color = new Color(RewardImage.color.r, RewardImage.color.g, RewardImage.color.b, 0f);
        randomNumber = Random.Range(lowestCoinReward, highestCoinReward);
        maxMoneyGiven = randomNumber + PlayerStats.Money;
        addMoney = randomNumber * Time.fixedDeltaTime;
        CoinReward.text = randomNumber.ToString();
        Debug.Log(randomNumber);
    }
    private void Update()
    {
        if (WinScreen.winScreenPopUp && RewardNumber == 0)
        {
            DeadScreen.deadScreenPopUp = false;
        }
        if (RewardNumber == 1)
        {
            CoinReward.enabled = true;
            RewardImage.color = new Color(RewardImage.color.r, RewardImage.color.g, RewardImage.color.b, 1f);
            RewardImage2.color = new Color(RewardImage.color.r, RewardImage.color.g, RewardImage.color.b, 1f);
            ChestOpened.enabled = true;
            ChestClosed.enabled = false;
            
            
            if (PlayerStats.Money <= maxMoneyGiven)
            {
                PlayerStats.Money += (int)addMoney;
                moneyleft += (int)addMoney;
                GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
            }

        }
        if (RewardNumber == 2)
        {
            if (PlayerStats.Money <= maxMoneyGiven)
            {
                PlayerStats.Money += randomNumber - moneyleft;
                Debug.Log("did it boys");
                return;
            }
            Debug.Log(randomNumber - moneyleft);
            SceneManager.LoadScene(4);
            chestMenu.chestScreenPopUp = false;
        }
    }

    public void OPNCHESTPLS()
    {
        RewardNumber += 1;



        Debug.Log("CHEST OPENED " + RewardNumber);
        
    }
}
