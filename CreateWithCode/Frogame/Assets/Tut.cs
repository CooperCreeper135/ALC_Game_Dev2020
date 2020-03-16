using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tut : MonoBehaviour
{
    public PlayerMovement player;
    public LLL nerd;
    public int james;
    public Level_loader level_Loader;
    void Update()
    {
        if (nerd.open == true && player.lvlgo == true)
        {
            level_Loader.LoadNextLevel();
        }


    }

}

