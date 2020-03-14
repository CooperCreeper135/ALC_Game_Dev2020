using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tut : MonoBehaviour
{
    public PlayerMovement player;
    public LLL nerd;
    void Update()
    {
        if (nerd.open == true)
        {
            if (player.lvlgo == true)
            {
                SceneManager.LoadScene(1);
                Debug.Log("what");
            }
        }


    }
}
