using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public float textSpeed; //dugang

    // bool IsOpen; //iba nga dugang
    // bool RLOpen; //iba nga dugang

    public Animator animator;
    public Animator anim2; //dugang nga animator

    private Queue<string> sentences;
    void Start()
    {
        Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGI);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG1);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG2);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG3);
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BG4);
        sentences = new Queue<string>();
        // animator = gameObject.GetComponent<Animator>(); //iba nga dugang
        // IsOpen = true;
        // RLOpen = false;
    }

    public void StartDialogue (Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        anim2.SetBool("RLOpen", false); //dugang para sa left and right
        animator.SetBool("IsOpen", true);

        Debug.Log("Starting conversation with " + dialogue.cname);

        nameText.text = dialogue.cname;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        if (sentences.Count == 0)
        {
            EndDialogue();
            OpenChoice();
            return;
        }

        string sentence = sentences.Dequeue();
        // Debug.Log(sentence);
        //dialogueText.text = sentence; //ginchange sa coroutine
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            // yield return null; //ginchange ko ang source
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        
        // Debug.Log("End of Story.");
        Bgmusic.bgmusic.Audio.Stop();

    }

    void OpenChoice()
    {
        anim2.SetBool("RLOpen", true); //dugangpara sa controls to next scene

    }

}
