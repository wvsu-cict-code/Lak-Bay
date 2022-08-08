using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    void Start()
    {
        screenQuestion.GetComponent<Text>().text = "What is the meaning of Baybay in Baybayin?";
        answerA.GetComponent<Text>().text = "A. To see";
        answerB.GetComponent<Text>().text = "B. To write";
        answerC.GetComponent<Text>().text = "C. To run";
        answerD.GetComponent<Text>().text = "D. To sleep";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
