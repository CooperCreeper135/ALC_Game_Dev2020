using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;

    public float restartDelay = 0.2f;

    public GameObject completeLevelUI;

    public GameObject tutorialUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void Tutorial()
    {
        tutorialUI.SetActive(true);
    }
    public void Tutorial1()
    {

        Invoke("Bad", .35f);
    }
    void Bad()
    {
        tutorialUI.SetActive(false);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
