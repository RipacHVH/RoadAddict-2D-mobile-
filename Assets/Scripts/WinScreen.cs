using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public static bool winScreenPopUp = false;

    public GameObject winScreenUI;
    private GameObject Car;
  



    private void Start()
    {
        Car = VehicleManager.CurrentCar;
    }

    private void Update()
    {

        if (winScreenPopUp)
        {
            Car.GetComponentInChildren<EndGame>().enabled = false;
            //PauseMenu.AlreadyPaused = true;
            GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();
 
            winScreenUI.SetActive(true);
            DeadScreen.deadScreenPopUp = false;
            VehicleManager.CurrentCar.GetComponent<CarController>().enabled = false;

        }

        



    }

    public void OpenChest()
    {
        chestMenu.chestScreenPopUp = true;
    }
    public void NextLevel()
    {
        winScreenUI.SetActive(false);
        Time.timeScale = 1f;
        winScreenPopUp = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PauseMenu.AlreadyPaused = false;
    }

    
}
