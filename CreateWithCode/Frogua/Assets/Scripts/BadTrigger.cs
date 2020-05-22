using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter2D()
    {
        gameManager.EndGame();

    }

}
