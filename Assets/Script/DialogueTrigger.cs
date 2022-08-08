using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<DManager>().StartDialogue(dialogue);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
    }
}
