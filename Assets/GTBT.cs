using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GTBT : MonoBehaviour
{
    public void GTtoBT ()
    {
        // Bgmusic.bgmusic.Audio.Stop();
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //number sng scne plus pila para kakadto sa designated scene
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB1);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG1);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG2);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG3);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG4);
        
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB2);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB3);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB4);
    }

    public void BTtoGameScene ()
    {
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //number sng scne plus pila para kakadto sa designated scene
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG1);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.Timer);
    }
}
