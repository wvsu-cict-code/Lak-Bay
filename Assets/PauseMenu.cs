using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static  bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public Timer timerp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }

    public void Resume() //public para mashow sa inspector
    {
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.Timer);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Bgmusic.bgmusic.Audio.UnPause();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; //normal time
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; //freez time or slowmo game
        GameIsPaused = true;
        timerp.StopTime();
    }

    public void LoadMenu()
    {
        Bgmusic.bgmusic.Audio.Stop();
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        // Debug.Log("Loading Menu..."); //paramashow lang sa console
    }

    public void QuitGame()
    {
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Application.Quit();
        // Debug.Log("Quitting Game...");//paramashow lang sa console
    }

    //dugang

    public void PauseB()
    {
        Bgmusic.bgmusic.Audio.Pause();
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

}
