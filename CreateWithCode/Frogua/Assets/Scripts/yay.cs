using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yay : MonoBehaviour
{
    public GameObject old;
    public GameObject next;
    void OnTriggerEnter2D(){
        old.SetActive(false);
        next.SetActive(true);
    }
}
