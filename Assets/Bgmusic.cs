using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgmusic : MonoBehaviour
{


public AudioSource Audio;


public AudioClip BGI;
public AudioClip BGG;

public AudioClip BGB1;

public AudioClip BGB2;

public AudioClip BGB3;

public AudioClip BGB4;

public AudioClip BG1;

public AudioClip BG2;

public AudioClip BG3;

public AudioClip BG4;

public AudioClip BG21;

public AudioClip BTR2;

public AudioClip Timer;

public AudioClip Menu;
public static Bgmusic bgmusic;

private void Awake()
{

if (bgmusic != null && bgmusic != this)
{
	Destroy(this.gameObject);
	return;
}

bgmusic = this;
DontDestroyOnLoad(this);

}
}

