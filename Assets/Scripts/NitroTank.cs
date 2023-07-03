using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NitroTank : MonoBehaviour
{
    public static float nitroTankAmount = 100;
    public static Slider NitroTankSlider;

    public static bool NitroTankEmpty = false;

    public GameObject NitroDefault;
    public GameObject NitroJeep;

    private void Start()
    {
        if (PlayerStats.CarNumber == 1)
        {
            NitroDefault.SetActive(true);
            NitroJeep.SetActive(false);
        }
        if (PlayerStats.CarNumber == 2)
        {
            NitroDefault.SetActive(false);
            NitroJeep.SetActive(true);
        }

        NitroTankSlider = GameObject.Find("SliderNitro").GetComponent<Slider>();
        nitroTankAmount = 100;
    }
    void NitroTankk()
    {
        if (nitroTankAmount == 0)
        {
            NitroTankEmpty = true;
        }
        if (nitroTankAmount > 0)
        {
            NitroTankEmpty = false;
        }

    }
    private void FixedUpdate()
    {
        NitroTankk();
    }
}
