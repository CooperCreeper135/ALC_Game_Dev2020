using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Levelcomplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
