using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LBTimerLoadScene : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    //private string sceneNameToLoad;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //number sng scne plus pila para kakadto sa designated scene
    }
    }

}
