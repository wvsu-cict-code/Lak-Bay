using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel(){
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync("Menu");

        while(!loadLevel.isDone){
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
