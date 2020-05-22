using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Levelcomplete : MonoBehaviour
{
    public int sceneIndex = 1;
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
