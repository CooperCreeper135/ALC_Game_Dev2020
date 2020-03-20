using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efff : MonoBehaviour
{
    public GameObject fly;
    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        fly.SetActive(false);

    }

}
