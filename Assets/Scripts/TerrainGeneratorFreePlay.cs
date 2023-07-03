using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class TerrainGeneratorFreePlay : MonoBehaviour
{
    public SpriteShapeController shape;
    public GameObject coin;
    int scale=700;
    int numofPoints=140;
    public static float xPos;
    public static float yPos;

    public GameObject Ramp;

    private void Start()
    {

        shape = GetComponent<SpriteShapeController>();
        float distanceBtwpoints = scale / numofPoints;
        shape.spline.SetPosition(2, shape.spline.GetPosition(2) + Vector3.right * scale);
        shape.spline.SetPosition(3, shape.spline.GetPosition(3) + Vector3.right * scale);

        for (int i = 0; i < numofPoints; i++)
        {
            xPos = shape.spline.GetPosition(i + 1).x + distanceBtwpoints;


            yPos = shape.spline.GetPosition(i + 1).y;

            //Spawn Coin
            //if (xPos >= 40 && xPos < 100)
            //{
            //    Instantiate(coin, new Vector3(xPos - 31.8f, yPos - 6.5f, 0), Quaternion.identity);
            //}
            //if (xPos >= 105 && xPos < 200)
            //{
            //    Instantiate(coin, new Vector3(xPos - 31.8f, yPos - 6.5f, 0), Quaternion.identity);
            //}
            //if (xPos >= 205 && xPos < 300)
            //{
            //    Instantiate(coin, new Vector3(xPos - 31.8f, yPos - 6.5f, 0), Quaternion.identity);
            //}
            if (xPos >= 40 && xPos < 670)
            {
                Instantiate(coin, new Vector3(xPos - 31.8f, yPos - 6.5f, 0), Quaternion.identity);
            }
            //

            //Spawn Ramp
            if (PlayerStats.InstantiateRamp >= 1)
            {
                if (xPos >= 100 && xPos < 105)
                {

                    Instantiate(Ramp, new Vector3(xPos - 31.8f, yPos - 6.5f, 0), Quaternion.identity);

                }
            }
            if (PlayerStats.InstantiateRamp >=2)
            {
                if (xPos >= 200 && xPos < 205)
                {

                    Instantiate(Ramp, new Vector3(xPos - 31.8f, yPos - 6.5f, 0), Quaternion.identity);

                }
            }
            if (PlayerStats.InstantiateRamp >= 3)
            {
                if (xPos >= 300 && xPos < 305)
                {

                    Instantiate(Ramp, new Vector3(xPos - 31.8f, yPos - 6.5f, 0), Quaternion.identity);

                }
            }
            //
            //Map Generation
            if (xPos <= 35)
            {
                shape.spline.InsertPointAt(i + 2, new Vector3(xPos, 6f, 0));
            }
            else if (xPos > 35 && xPos <= 80)
            {
                shape.spline.InsertPointAt(i + 2, new Vector3(xPos, 15 * Mathf.PerlinNoise(i * Random.Range(6f, 6.009f), 0)));
            }
            else if (xPos > 80 && xPos <= 200)
            {
                shape.spline.InsertPointAt(i + 2, new Vector3(xPos, 15 * Mathf.PerlinNoise(i * Random.Range(6f, 6.006f), 0)));
            }
            else if (xPos > 200 && xPos <= 660)
            {
                shape.spline.InsertPointAt(i + 2, new Vector3(xPos, 15 * Mathf.PerlinNoise(i * Random.Range(6f, 6.003f), 0)));
            }
            
            else if (xPos > 660)
            {
                shape.spline.InsertPointAt(i + 2, new Vector3(xPos, 6, 0));
            }
            //
        }

        for (int i = 2; i < numofPoints + 2; i++)
        {
            shape.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
            shape.spline.SetLeftTangent(i, new Vector3(-2.8f, 0, 0));
            shape.spline.SetRightTangent(i, new Vector3(2.8f, 0, 0));

        }
        


    }






}
