using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneToIntroScence : MonoBehaviour
{
    public void CTtoIS ()
    {
        // SceneManager.LoadScene(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //number sng scne plus pila para kakadto sa designated scene
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
    }

}
