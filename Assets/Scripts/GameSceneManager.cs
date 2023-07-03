using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void PlayGame()
    {
        PauseMenu.AlreadyPaused = false;
        
        SceneManager.LoadScene(6);
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();

    }
    public void goToSettings()
    {
        SceneManager.LoadScene(3);
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
    public void GoToMainMenu()
    {
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
        PauseMenu.AlreadyPaused = false;
        WinScreen.winScreenPopUp = false;
        DeadScreen.deadScreenPopUp = false;

        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void GoToVehicles()
    {
        SceneManager.LoadScene(1);
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }    
    public void BackToMainMenu()
    {
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
        PauseMenu.AlreadyPaused = false;
        WinScreen.winScreenPopUp = false;
        DeadScreen.deadScreenPopUp = false;

        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void UpgradeMenu()
    {
        PauseMenu.AlreadyPaused = false;
        SceneManager.LoadScene(5);
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();

    }

    public void GoToQuests()
    {
        PauseMenu.AlreadyPaused = false;
        SceneManager.LoadScene(2);
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }

    public void GoToLevelsMenu()
    {
        PauseMenu.AlreadyPaused = false;
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
    public void GoTo1stLevel()
    {
        PauseMenu.AlreadyPaused = false;
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
        Application.Quit();
    }
    
    public void GiveMoney()
    {
        PlayerStats.Money += 50000;
        GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
    }
}
