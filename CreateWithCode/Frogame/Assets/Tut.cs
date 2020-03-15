using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tut : MonoBehaviour
{
    public PlayerMovement player;
    public LLL nerd;
    public int james;
    void Update()
    {
        if (nerd.open == true)
        {
            if (player.lvlgo == true)
            {
                SceneManager.LoadScene(james);
                Debug.Log("what");
            }
        }


    }
}
