using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LakbayMainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //pila ang iadd para makadto sa next scene
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
    }

    public void Continue ()
    {
        PlayerPrefs.HasKey("SavedLevel");
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
    }

    public void Credits ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15); //pila ang iadd para makadto sa next scene
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
    }


    public void QuitGame ()
    {
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void PlayGame1 ()
    {
        SceneManager.LoadScene("1Stage1BT"); //"name sng scene"
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.Stop();
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB1);
    }

    public void Continue1 ()
    {
        PlayerPrefs.HasKey("SavedLevel");
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
    }

    public void QuitGame1 ()
    {
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Debug.Log("Quit!");
        Application.Quit();
    }
}

// <a target="_blank" href="https://icons8.com/icon/Ldtq_qMROPQg/home-button">Home Button</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
// <a target="_blank" href="https://icons8.comundefined">Home Button</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>