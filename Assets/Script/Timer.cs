using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 60;
    public bool takingAway = false;

    public HeartSystem hsanim;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0) 
        {
            StartCoroutine(TimerTake());
        }
        if (secondsLeft <= 0)
        {
            hsanim.animg.SetBool("GOpen", true);;
            StopCoroutine(TimerTake());
            StopTime();
        }
    }

    // void NoTime()
    // {

    //     if (secondsLeft == 0)
    //     {
    //         hsanim.Update();
    //         StopTime();
    //     }
    // }

    public void StopTime()
    {
        StopCoroutine(TimerTake());
        stopped = true;
        Debug.Log("STOP");
    }
    
    private bool stopped = false;

    IEnumerator TimerTake()
    {
        takingAway = true;
        // yield return new WaitForSeconds(1);
        // secondsLeft -= 1;
        // textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        // takingAway = false;
        // stopped = false;

        int i = 0;
        stopped = false;
        do
        {  
            yield return new WaitForSeconds(1);
            secondsLeft -= 1;
            textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        } 
            while(!stopped && i<1);
    }
}
