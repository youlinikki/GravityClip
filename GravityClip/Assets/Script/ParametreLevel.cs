using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ParametreLevel : MonoBehaviour
{
    public AudioMixer audioMixer;




    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume niveau", volume);
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}