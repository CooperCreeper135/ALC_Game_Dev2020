﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue (){
        FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
    }
    public void StopDialogue (){
        FindObjectOfType<dialogueManager>().EndDialogue();
    }
    void OnTriggerEnter2D(){
        TriggerDialogue();
    }
    void OnTriggerExit2D(){
        StopDialogue();
    }
}