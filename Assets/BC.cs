using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BC : MonoBehaviour
{
    public GameObject skip = null; //add on new
    public GameObject skipex = null;

    public void Start()
    {
        skipex.SetActive(false);
        skip.SetActive(false);
        //ShowButton();
        StartCoroutine(WaitBFShow());
    }

    private void ShowButton()
    {
        skipex.SetActive(true);

        skip.SetActive(true);
    }

    IEnumerator WaitBFShow() //sawakASSS naggana na sa 12/14 huhu
    {
        // skip.SetActive(false);
        yield return new WaitForSeconds(10); //waitfewseconds
        skip.SetActive(true);
    }

}
