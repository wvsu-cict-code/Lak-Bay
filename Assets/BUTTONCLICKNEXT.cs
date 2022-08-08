using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTONCLICKNEXT : MonoBehaviour
{
    public void BUTTNEXT1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGG);
    }

    public void BUTTNEXT2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG1);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.Timer);
    }

    public void BUTTNEXT3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG2);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.Timer);
    }

    public void BUTTNEXT4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);

        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG3);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.Timer);
    }

    public void BUTTNEXT5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG4);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.Timer);
    }

    public void BUTTNEXTB1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB1);
    }

    public void BUTTNEXTB2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB2);
    }

    public void BUTTNEXTB3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB3);
    }

    public void BUTTNEXTB4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB4);
    }

    public void BUTTNEXTBTR2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BTR2);
    }
    public void BUTTNEXTR2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG21);
    }

    public void BUTTNEXTEND()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.Stop();
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.Menu);
    }
}
