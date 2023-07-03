using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public static float CoinValue = 1f;
    private void Update()
    {
        CoinValue = PlayerStats.CoinValue;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            PlayerStats.Money += (int)PlayerStats.CoinValue;

            Destroy(gameObject);
        }

    }

}