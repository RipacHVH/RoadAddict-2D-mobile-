using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int MaxScore = 0;
    public Text ScoreText;


    private float timer = 0f;
    public int delayAmount = 1;
    void Start()
    {
        score = 0;
        Debug.Log(PlayerStats.MaxScore);
    }
    void Update()
    {
        ScoreText.text = score.ToString();
        timer += Time.deltaTime;

        if (timer >= delayAmount && !PauseMenu.AlreadyPaused)
        {
            timer = 0.8f;
            score += 1;
        }
    }


}
