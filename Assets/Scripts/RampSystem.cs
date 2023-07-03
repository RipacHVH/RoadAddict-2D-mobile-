using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RampSystem : MonoBehaviour
{
    public static bool RampON = false;



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            RampON = true;

        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            RampON = false;


            //if (PlayerStats.InstantiateRamp == 1)
            //{
            //    PlayerStats.speed -= 3000;
            //}
            //if (PlayerStats.InstantiateRamp == 2)
            //{
            //    PlayerStats.speed -= 6000;
            //}
            //if (PlayerStats.InstantiateRamp == 3)
            //{
            //    PlayerStats.speed -= 9000;
            //}


        }
    }
}
