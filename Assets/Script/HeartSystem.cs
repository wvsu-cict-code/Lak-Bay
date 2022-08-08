using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts; 
    public GameObject[] ehearts; //enemy
    private int life;
    private int elife; //enemy
    private bool dead;
    private bool edead; //enemy

    public Animator animg;
    public Animator animn;
    public Timer timer;



    private void Start()
    {
        life = hearts.Length;
        elife = ehearts.Length; //enemy

        animg.SetBool("GOpen", false);
        animn.SetBool("NSOpen", false);
        // animrun.SetBool("isRunning", false);
    }


    public void Update()
    {
        if (dead == true)
        {
            Bgmusic.bgmusic.Audio.Pause();
            Destroy (GameObject.FindWithTag("Player"), .50f);
            timer.StopTime();
            // Invoke("waitforGOpen", 5);
            animg.SetBool("GOpen", true);
        }

        if (edead == true) //enemy
        {
            Bgmusic.bgmusic.Audio.Pause();
            Destroy (GameObject.FindWithTag("Enemy"), .50f);
            timer.StopTime(); //pause countdown time
            // Invoke("waitforNSOpen", 5);   
            animn.SetBool("NSOpen", true);
            Bgmusic.bgmusic.Audio.Stop();  
        }
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d; 
            Destroy(hearts[life].gameObject);
        }
            if(life == 0)
            {
                dead = true;
            }
            
    }

    public void ETakeDamage(int e) //enemy
    {
        if (elife >= 1)
        {
            elife -= e; 
            Destroy(ehearts[elife].gameObject);
            // Debug.Log("Runnnn");
        }
            if(elife == 0)
            {
                edead = true;
                animn.SetBool("NSOpen", true);
                Debug.Log("WIN");
            }
    }

    // public void waitforGOpen()
    // {
    //     animg.SetBool("GOpen", true);
    // }

    // public void waitforNSOpen()
    // {
    //     animn.SetBool("NSOpen", true);
    // }
}

