using UnityEngine;
using UnityEngine.SceneManagement;

public class carbad : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
	{
        if (col.tag == "Goomba")
		{
			Debug.Log("gameover");
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
