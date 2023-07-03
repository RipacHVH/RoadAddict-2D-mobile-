using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Rigidbody2D))]
public class CarController : MonoBehaviour
{
    [SerializeField]
    public static float speed = 1500f;
    public float rotationSpeed;
    public float speedNitro = 30;


    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    public static CircleCollider2D w_collider;
    public static float friction = 1f;

    public Rigidbody2D rb;



    

    private float movement = 0f;
    public float rotation = 0f;

    public static bool moveRight = false;
    public static bool moveLeft = false;
    public static bool rotateBackward = false;
    public static bool rotateForward = false;



    //Left Button
    public void LeftButtonDown()
    {
        moveLeft = true;
        rotateBackward = true;
        
    }
    public void LeftButtonUp()
    {
        moveLeft = false;
        rotateBackward = false;
        
    }


    //Right Button
    public void RightButtonDown()
    {
        moveRight = true;
        rotateForward = true;
    }
    public void RightButtonUp()
    {
        moveRight = false;
        rotateForward = false;
    }
    bool nitroOn = false;
    public void NitroButtonDown()
    {
        nitroOn = true;
    }
    public void NitroButtonUp()
    {
        nitroOn = false;
        
        
    }


    private void Start()
    {
        w_collider = GameObject.Find("BackWheel").GetComponent<CircleCollider2D>();
        
    }

    
    void Update()
    {
        friction = PlayerStats.friction;
        
        w_collider.sharedMaterial.friction = PlayerStats.friction;
        
        speed = PlayerStats.speed;

    }

    void FixedUpdate()
    {
        if (RampSystem.RampON)
        {
            rb.AddTorque(100 );
            rb.AddForce(transform.right * 300);
        }





        //FindObjectOfType<AudioManager>().Play("CarEngine");
        NitroVoid();
        CarMovement();
        CarRotation();
        if (movement == 0f)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;

        }
        else
        {
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 500000 };

            
                backWheel.useMotor = true;
                frontWheel.useMotor = true;
                backWheel.motor = motor;
                frontWheel.motor = motor;
 
        }
       
        rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
    }

    void NitroVoid()
    {
        //if ((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("MainLevel")))
        //{
        //    Ball.transform.position = new Vector2(Car.transform.position.x - 30, Car.transform.position.y);
        //}
        NitroTank.NitroTankSlider.value = NitroTank.nitroTankAmount / 100;
        if (nitroOn && !NitroTank.NitroTankEmpty)
        {

            if (NitroTank.nitroTankAmount > 0)
            {
                rb.AddTorque(250f * Time.fixedDeltaTime);
                rb.AddForce(transform.right * speedNitro);
                NitroTank.nitroTankAmount -= 2;
            }

        }
        if (!nitroOn)
        {
            if (NitroTank.nitroTankAmount < 100)
            {
                NitroTank.nitroTankAmount += 0.15f;
            }
        }
    }
    void CarRotation()
    {
        if (rotateBackward)
        {
            rotation = 0.2f;
        }
        else if (rotateForward)
        {
            rotation = -1f;
        }
        else
        {
            rotation = 0f;
        }

    }

    void CarMovement()
    {
        if(moveLeft)
        {
            movement = speed;
            
            
        }
        
        else if (moveRight)
        {
            movement = -speed;
            if (nitroOn && !NitroTank.NitroTankEmpty)
            {

                if (NitroTank.nitroTankAmount > 0)
                {
                    rb.AddTorque(250f * Time.fixedDeltaTime);
                    rb.AddForce(transform.right * speedNitro);
                    NitroTank.nitroTankAmount -= 2;
                }

            }
            if (!nitroOn)
            {
                if (NitroTank.nitroTankAmount < 100)
                {
                    NitroTank.nitroTankAmount += 0.15f;
                }
            }
        }
        else
        {
            movement = 0f;
        }
    }
    
}
