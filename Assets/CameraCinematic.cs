using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCinematic : MonoBehaviour
{
    float CameraSize = 9.5f;
    GameObject[] coins;

    // Start is called before the first frame update
    void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("Coins");
        foreach (GameObject coin in coins)
        {
            Destroy(coin);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.orthographicSize = CameraSize;
        if (CameraSize >= 7f)
        {
            CameraSize -= 0.03f / CameraSize;
        }
        transform.position += Vector3.right * Time.deltaTime * 5f;
        
    }
}
