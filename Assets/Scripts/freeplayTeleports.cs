using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeplayTeleports : MonoBehaviour
{
    public GameObject Terrain1;
    public GameObject Terrain2;
    GameObject[] coins;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag("Player"))
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
        
        if (collision.CompareTag("Player"))
        {
            coins = GameObject.FindGameObjectsWithTag("Coins");
            foreach (GameObject coin in coins)
            {
                Destroy(coin);
            }



            VehicleManager.CurrentCar.transform.position = new Vector2(-14, -0.5f);
            Terrain1.SetActive(false);
            Terrain2.SetActive(true);
            Camera.main.orthographicSize = 9.5f;
            
        }


    }
    
}
