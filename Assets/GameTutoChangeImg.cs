using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTutoChangeImg : MonoBehaviour
{
    
public Image startingImage;
public Sprite spriteOne;
public Sprite spriteTwo;
public Sprite spriteThree;
public Sprite spriteFour;

public Sprite spriteFive;

public Sprite spriteSix;

public Sprite spriteSeven;

public Sprite spriteEight;

public Sprite spriteNine;

public Sprite spriteTen;

public Sprite spriteEleven;

public Sprite spriteTwelve;

public Sprite spriteThirteen;

public Sprite spriteFourteen;

public Sprite spriteFifteen;

public Sprite spriteSixteen;

public Sprite spriteSeventeen;
public int imageNumber = 0;

public Animator animbutt; //button animation
public Animator animcont;

public Animator animbb; //Baybayin Lesson Text

void Start()
    {
        // Bgmusic.bgmusic.Audio.PlayOneShot(Bgmusic.bgmusic.BGG);
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
	 	startingImage.sprite = spriteThree;
    
    if (imageNumber == 4)
	 	startingImage.sprite = spriteFour;
    
    if (imageNumber == 5)
	 	startingImage.sprite = spriteFive;

    if (imageNumber == 6)
	 	startingImage.sprite = spriteSix;

    if (imageNumber == 7)
	 	startingImage.sprite = spriteSeven;

    if (imageNumber == 8)
	 	startingImage.sprite = spriteEight;

    if (imageNumber == 9)
	 	startingImage.sprite = spriteNine;

    if (imageNumber == 10)
	 	startingImage.sprite = spriteTen;

    if (imageNumber == 11)
	 	startingImage.sprite = spriteEleven;

    if (imageNumber == 12)
	 	startingImage.sprite = spriteTwelve;

    if (imageNumber == 13)
	 	startingImage.sprite = spriteThirteen;

    if (imageNumber == 14)
	 	startingImage.sprite = spriteFourteen;

    if (imageNumber == 15)
	 	startingImage.sprite = spriteFifteen;

    if (imageNumber == 16)
	 	startingImage.sprite = spriteSixteen;

	if (imageNumber == 17)
	{
		startingImage.sprite = spriteSeventeen;
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