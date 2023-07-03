using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipChecker : MonoBehaviour
{

public bool rot90 = false;
public bool rot180 = false;
public bool rot270 = false;

public static string score;
public static int flips = 0;


public Text showScoreText;


    public void Update()
    {
        flips = PlayerStats.flips;


        Transform transform = VehicleManager.CurrentCar.transform;
        
        Quaternion position = transform.rotation;
        showScoreText.text = score;

        position.z = transform.eulerAngles.z;
        
        
        if (position.z >= 0)
        {
            if (position.z >= 90 && position.z < 359 && !rot90)
            {
                rot90 = true;
                
            }
            if (position.z >= 180 && position.z < 190 && rot90 && !rot180)
            {
                rot180 = true;

            }
            if (position.z >= 270 && position.z < 359 && rot180)
            {
                rot270 = true;

            }
            
            if (position.z >= 330 && position.z < 360 && rot270)
            {
                rot90 = false;
                rot180 = false;
                rot270 = false;
                StartCoroutine(Flip());
                position.z = 0;
                
            }
            
        }
        else
        {
            rot90 = false;
            rot180 = false;
            rot270 = false;
            position.z = 0;
        }
    }
IEnumerator Flip()
{
        if (!DeadScreen.deadScreenPopUp && !WinScreen.winScreenPopUp)
        {
            PlayerStats.flips += 1;
            Score.score += 10;
            score = "Flip";
            yield return new WaitForSeconds(0.3f);
            score = "";
        }
}
}
