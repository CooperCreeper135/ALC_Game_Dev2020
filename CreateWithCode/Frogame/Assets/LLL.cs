using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLL : MonoBehaviour
{
    public GameManager gameManager;
    public bool open = false;
    public Animator animator;
    void OnTriggerEnter2D()
    {
        gameManager.Tutorial();
        open = true;
        animator.SetBool("open", true);
    }
    void OnTriggerExit2D()
    {
        gameManager.Tutorial1();
        open = false;
        animator.SetBool("open", false);
    }
}
