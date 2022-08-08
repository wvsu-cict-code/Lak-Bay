using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LBChangeImage : MonoBehaviour
{
public Image startingImage;
public Sprite spriteOne;
public Sprite spriteTwo;
public Sprite spriteThree;
// public Sprite spriteFour;
public int imageNumber = 0;

public Animator animbutt; //button animation
public Animator animcont;
public Animator animbb; //Baybayin Lesson Text

void Start()
    {
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGB1);
        animbutt.SetBool("BTOpen", true);
        animcont.SetBool("CBOpen", false);
        animbb.SetBool("bbclose", false);
    }

public void WhenButtonClicked () 
{
    SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
    animbb.SetBool("bbclose", true);

	imageNumber++;
	if (imageNumber == 1)
		startingImage.sprite = spriteOne;

	if (imageNumber == 2)
	 	startingImage.sprite = spriteTwo;

	if (imageNumber == 3)
	{
        Bgmusic.bgmusic.Audio.Pause();
		startingImage.sprite = spriteThree;
        imageNumber = 0;
	}

    


    if (imageNumber == 0)
    {
        // Debug.Log("Gana");
        CloseButt();
        OpenContinue();
    }

}

    void CloseButt()
    {
        animbutt.SetBool("BTOpen", false); 
    }

    void OpenContinue()
    {
        animcont.SetBool("CBOpen", true);
        Bgmusic.bgmusic.Audio.Stop();
    }

}