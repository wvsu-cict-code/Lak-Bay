using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LBSS1 : MonoBehaviour
{
    public void OnTriggerEnter2D ()
    {
        // SceneManager.LoadScene(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}

