using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chestMenu : MonoBehaviour
{
    public static bool chestScreenPopUp = false;

    public GameObject chestScreenUI;
    bool UIDisabled = false;
    private void Update()
    {

        if (chestScreenPopUp)
        {
            
            PauseMenu.AlreadyPaused = true;
            WinScreen.winScreenPopUp = false;
            chestScreenUI.SetActive(true);
            if (!UIDisabled)
            {
                GameObject.Find("Movement").SetActive(false);
                GameObject.Find("Nitros").SetActive(false);
                GameObject.Find("PauseCanvas").SetActive(false);
                UIDisabled = true;
            }
            GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
        }
       



    }
}
