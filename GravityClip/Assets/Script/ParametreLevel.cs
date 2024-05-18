using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ParametreLevel : MonoBehaviour
{
    public AudioMixer levelmixer;




    public void SetVolume(float volume)
    {
        levelmixer.SetFloat("Volume2", volume);
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}