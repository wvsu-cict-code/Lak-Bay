using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class R2QManager : MonoBehaviour
{
    public List<LakbayQandA> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GoPanel;

    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;

    // public Animator animg;

    private void Start()
    {
        // animg.SetBool("GOpen", false);
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        // SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //loadscene
        Bgmusic.bgmusic.Audio.Stop();
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG21);
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.Timer);
    }

    public void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        // animg.SetBool("GOpen", true);
        ScoreTxt.text =  score + "/" + totalQuestions;
        Bgmusic.bgmusic.Audio.Stop();
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong() //when answer is wrong
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Region2AnswerScript>().isCorrect = false;
            // options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            options[i].transform.GetChild(0).GetComponent<Image>().sprite = QnA[currentQuestion].Answers[i];
            

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<Region2AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
        currentQuestion = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[currentQuestion].Question;
        SetAnswers();
    }
    else
    {
        Debug.Log("Out of Questions");
        //GameOver();
    }

    }
}
