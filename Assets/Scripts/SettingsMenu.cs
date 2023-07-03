using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public static bool Muted = false;
    public void AudioOFF()
    {
        PlayerStats.Muted = true;
    }
    public void AudioON()
    {
        PlayerStats.Muted = false;
    }
    private void Update()
    {
        if(PlayerStats.Muted)
        {
            AudioListener.pause = true;
        }
        else
        {
            AudioListener.pause = false;
        }
    }

}
