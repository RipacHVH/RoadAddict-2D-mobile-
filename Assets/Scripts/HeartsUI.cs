using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour
{
    public Text HeartsText;


    private void Update()
    {
        HeartsText.text = PlayerStats.Hearts.ToString();
    }

    public void WatchadHearts()
    {
        PlayerStats.Hearts += 1;
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
}
