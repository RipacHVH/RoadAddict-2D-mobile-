using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScreen : MonoBehaviour
{
    public static bool deadScreenPopUp = false;

    public GameObject deadScreenUI;
    private GameObject Car;
    public GameObject Ball;
    private GameObject Enemy;
    public GameObject ReviveButton;

    public bool AlreadyRevived = false;


    private void Start()
    {
        Car = VehicleManager.CurrentCar;
        Enemy = GameObject.Find("Enemy");
    }
    private void FixedUpdate()
    {

        

        if (deadScreenPopUp && !WinScreen.winScreenPopUp)
            {
            PauseMenu.AlreadyPaused = true;
            if (Score.score > PlayerStats.MaxScore)
            {
                PlayerStats.MaxScore = Score.score;
            }
            GameObject.Find("GameMaster").GetComponent<PlayerStats>().SavePlayer();

            

            deadScreenUI.SetActive(true);
            WinScreen.winScreenPopUp = false;
            Car.GetComponent<CarController>().enabled = false;

            
        }
       
    }
    public void Revive()
    {
        if (PlayerStats.Hearts >= 1)
        {
            PlayerStats.Hearts -= 1;
            Car.transform.SetPositionAndRotation(Car.transform.position + new Vector3(0, 3, 0), Quaternion.Euler(0, 0, 0));
            //Destroy(Enemy);
            if ((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainLevel")))
            {
                Ball.transform.position = new Vector2(Car.transform.position.x - 30, Car.transform.position.y);
            }


            Car.SetActive(true);
            deadScreenUI.SetActive(false);
            Time.timeScale = 1f;
            deadScreenPopUp = false;
            VehicleManager.CurrentCar.GetComponent<CarController>().enabled = true;
            PauseMenu.AlreadyPaused = false;
            Destroy(ReviveButton);
        }
        if(PlayerStats.Hearts <1)
        {
            //Run an ad
            Car.transform.SetPositionAndRotation(Car.transform.position + new Vector3(0, 3, 0), Quaternion.Euler(0, 0, 0));
            //Destroy(Enemy);
            if ((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainLevel")))
            {
                Ball.transform.position = new Vector2(Car.transform.position.x - 30, Car.transform.position.y);
            }


            Car.SetActive(true);
            deadScreenUI.SetActive(false);
            Time.timeScale = 1f;
            deadScreenPopUp = false;
            VehicleManager.CurrentCar.GetComponent<CarController>().enabled = true;
            PauseMenu.AlreadyPaused = false;
            Destroy(ReviveButton);
        }
    }
    public void PlayAgain()
    {
        deadScreenUI.SetActive(false);
        Time.timeScale = 1f;
        deadScreenPopUp = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PauseMenu.AlreadyPaused = false;
    }


    
}
