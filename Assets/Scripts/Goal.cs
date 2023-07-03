using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public static bool addLevel = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag("Player"))
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}

            if(collision.CompareTag("Player"))
            {
                Debug.Log("Game WON!");
                WinScreen.winScreenPopUp = true;
                LevelsSystem.ThisLevel = SceneManager.GetActiveScene().buildIndex - 6;
                addLevel = true;
            }


    }


}
