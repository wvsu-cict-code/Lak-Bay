using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Region2AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public R2QManager RlakbayqManager;
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
           RlakbayqManager.correct();
           eheartsystem.ETakeDamage(e);
           runhit();
        //    animenrun.SetBool("Whit", false);

       }
       else
       {
           SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Correct);
           Debug.Log("Wrong Answer");
           RlakbayqManager.wrong();
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
        animenrun.CrossFade("SantelmoHit", .50f);
        animenrun.SetBool("Shit", false);
    }

    public void enrunhit()
    {
        animenrun.CrossFade("SantelmoAttack", .70f);
        animenrun.CrossFade("SantelmoAttackStay", .50f);
        animenrun.SetBool("Sattack", false);
        animrun.CrossFade("MChit", .50f);
        animrun.SetBool("Dhit", false);
    }


}



//heartsys file then ang take damage class nga halin sa muna nga file