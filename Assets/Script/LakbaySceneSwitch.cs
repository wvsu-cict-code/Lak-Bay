using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LakbaySceneSwitch : MonoBehaviour
{
    public void OnTriggerEnter2D ()
    {
        // SceneManager.LoadScene(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
