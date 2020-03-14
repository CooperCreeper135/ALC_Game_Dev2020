using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLL : MonoBehaviour
{
    public GameManager gameManager;
    public bool open = false;

    void OnTriggerEnter2D()
    {
        gameManager.Tutorial();
        open = true;
    }
    void OnTriggerExit2D()
    {
        gameManager.Tutorial1();
        open = false;
    }
}
