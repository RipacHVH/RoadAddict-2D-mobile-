using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour
{
    
    public static bool AlreadyPaused = false;

    public GameObject pauseMenuUI;

    private void Start()
    {
        AlreadyPaused = false;
    }

    public void PauseButtonClicked()
    {
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
        if (AlreadyPaused)
        {
            dontPause();
        }

        if (AlreadyPaused == false)
        {
            Pause();
        }
    }



    void dontPause()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Resume ()
    {
        GameObject.Find("PauseButton").GetComponent<Button>().interactable = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        
        AlreadyPaused = false;
    }

    void Pause ()
    {
        GameObject.Find("PauseButton").GetComponent<Button>().interactable = false;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        if (Score.score > PlayerStats.MaxScore)
        {
            PlayerStats.MaxScore = Score.score;
        }
        AlreadyPaused = true;
    }

    

}
