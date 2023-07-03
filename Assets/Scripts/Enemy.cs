using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float enemySpeed;
    public GameObject Ball;
    private GameObject Car;



    private void Start()
    {
        Car = VehicleManager.CurrentCar;
        rb = GetComponent<Rigidbody2D>();
        
    }


    float speed;
    void Update()
    {
        speed = rb.velocity.magnitude;
        if (speed < 0.005)
        {
            Ball.transform.position = new Vector2(Ball.transform.position.x + 1, 5);
            Debug.Log("stuck");
        }
    }

    private void FixedUpdate()
    {


        if (Ball.transform.position.x >= 655f)
        {

            Ball.transform.position = new Vector2(-14, -0.5f);
        }

        if (PlayerStats.speed <= 2500)
        {
            enemySpeed = 7f;
        }
        if (PlayerStats.speed > 2500 )
        {
            enemySpeed = 8.2f;
        }
        
    }
    public GameObject[] Explosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            StartCoroutine(WaitForExplosion());

        }
        
        if (collision.gameObject.tag == "Collidable")
        {
            //rb.mass = 1f;
            rb.gravityScale = 1f;
            rb.velocity = Vector2.right * enemySpeed;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collidable")
        {
            //rb.mass = 5000f;
            rb.gravityScale = 4f;
        }
    }
    IEnumerator WaitForExplosion()
    {
        Explosion[0].SetActive(true);
        Explosion[1].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        VehicleManager.CurrentCar.SetActive(false);
        Explosion[0].SetActive(false);
        Explosion[1].SetActive(false);

        DeadScreen.deadScreenPopUp = true;
    }
}