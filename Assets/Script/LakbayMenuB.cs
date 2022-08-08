using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LakbayMenuB : MonoBehaviour
{
    private int currentSceneIndex;

    public void LoadMenu()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Continue", currentSceneIndex);
        SceneManager.LoadScene(0);
    }
}
