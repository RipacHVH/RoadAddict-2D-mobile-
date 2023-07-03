using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelsSystem : MonoBehaviour
{
    
    public static int levelReached = 1;
    public static int ThisLevel;
    int LevelYouWannaOpenINT;

    public Button[] LevelButtons;
    public GameObject[] Lock;
    public Text[] LevelNumber;

    public void StartLevel()
    {
        string LevelYouWannaOpen = EventSystem.current.currentSelectedGameObject.name;
        int.TryParse(LevelYouWannaOpen, out LevelYouWannaOpenINT);
        Debug.Log(LevelYouWannaOpenINT);

        SceneManager.LoadScene(LevelYouWannaOpenINT + 6);
    }


    private void Start()
    {

        ThisLevel = SceneManager.GetActiveScene().buildIndex;


        Debug.Log(PlayerStats.levelReached);
        for (int i = 0; i < LevelButtons.Length; i++)
        {

            
            

            if (i + 1 > PlayerStats.levelReached)
            {
                LevelButtons[i].interactable = false;
                Lock[i].SetActive(true);
                LevelNumber[i].enabled = false;
                
            }
        }
    }
    private void FixedUpdate()
    {
        if (Goal.addLevel)
        {
            Debug.Log(ThisLevel);
            if (ThisLevel == PlayerStats.levelReached)
            {
                PlayerStats.levelReached = ThisLevel + 1;
            }
            Goal.addLevel = false;
            
        }
        
    }

}
