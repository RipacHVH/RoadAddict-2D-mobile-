using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject Car;
    Transform target;
    public float zoomSpeed = 0.03f;
    float CameraSize = 9.5f;

    private void Start()
    {
        Car = VehicleManager.CurrentCar;
        target = Car.GetComponent<Transform>();
    }
    private void Update()
    {
        Vector3 newPosition = target.position;
        newPosition.z = -10;
        transform.position = newPosition;
        Camera.main.orthographicSize = CameraSize;
        if (CameraSize >= 6f)
        {
            CameraSize -= zoomSpeed / CameraSize;
        }
    }
}
