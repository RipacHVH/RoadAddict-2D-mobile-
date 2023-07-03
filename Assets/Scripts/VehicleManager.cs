using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehicleManager : MonoBehaviour
{
    public static int CarNumber = 1;
    public static GameObject CurrentCar;
    public GameObject DefaultCar;
    public GameObject JeepCar;
    

    private void Start()
    {
        Debug.Log("car -" + PlayerStats.CarNumber);
        if (PlayerStats.CarNumber == 1)
        {
            CurrentCar = DefaultCar;
            CurrentCar.SetActive(true);
            Debug.Log("Jeep Spawned");
        }
        if (PlayerStats.CarNumber == 2)
        {
            CurrentCar = JeepCar;
            CurrentCar.SetActive(true);
            Debug.Log("Jeep Spawned");

        }
    }
    
    
    
}
