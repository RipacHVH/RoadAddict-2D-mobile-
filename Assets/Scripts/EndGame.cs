using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private GameObject Car;
    private void Start()
    {
        Car = VehicleManager.CurrentCar;
    }
    public GameObject[] Explosion;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Collidable"))
        {
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            StartCoroutine(WaitForExplosion());
        }
        
    }
    IEnumerator WaitForExplosion()
    {
        Explosion[0].SetActive(true);
        Explosion[1].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Explosion[0].SetActive(false);
        Explosion[1].SetActive(false);
        Car.SetActive(false);
        DeadScreen.deadScreenPopUp = true;
    }
}
