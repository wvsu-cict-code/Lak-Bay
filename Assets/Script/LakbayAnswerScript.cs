using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LakbayAnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public LakbayQManager lakbayqManager;
    public HeartSystem heartsystem;
    public HeartSystem eheartsystem;
    public int d;
    public int e;

    public Animator animrun;
    public Animator animenrun;

    // [SerializeField] private float timeInSeconds;
    public void Answer()
   {
       if (isCorrect)
       {
           SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Correct);
           Debug.Log("Correct Answer");
           lakbayqManager.correct();
           eheartsystem.ETakeDamage(e);
           runhit();
        //    animenrun.SetBool("Whit", false);

       }
       else
       {
           SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Wrong);
           Debug.Log("Wrong Answer");
           lakbayqManager.wrong();
           heartsystem.TakeDamage(d);
           enrunhit();
        //    animrun.SetBool("Dhit", false);
       }
    }

    public void runhit()
    {
        animrun.CrossFade("MCrun", .70f);
        animrun.CrossFade("MCsword1", .20f);
        animrun.SetBool("Hit", false);
        animenrun.CrossFade("WLhit", .50f);
        animenrun.SetBool("Whit", false);
    }

    public void enrunhit()
    {
        animenrun.CrossFade("WLmove", .70f);
        animenrun.CrossFade("WLattack", .50f);
        animenrun.SetBool("Wattack", false);
        animrun.CrossFade("MChit", .50f);
        animrun.SetBool("Dhit", false);
    }


}



//heartsys file then ang take damage class nga halin sa muna nga file