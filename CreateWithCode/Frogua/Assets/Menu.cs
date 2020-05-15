using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject gameObject;
    public bool first;
    // Start is called before the first frame update
    void Start()
    {
        if (first = true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Space") && first == true)
        {
            first = false;
            gameObject.SetActive(false);
            SceneManager.LoadScene(1);

        }
        if (first == false)
        {
            gameObject.SetActive(false);
        }


    }
}
