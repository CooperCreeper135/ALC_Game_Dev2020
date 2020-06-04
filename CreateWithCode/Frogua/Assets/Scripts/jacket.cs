using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jacket : MonoBehaviour
{
    public GameObject jackest;
    public GameObject dialogue;
    public GameObject next;
    void OnTriggerEnter2D(){
        jackest.SetActive(false);
        next.SetActive(true);
        dialogue.SetActive(false);
    }
}
