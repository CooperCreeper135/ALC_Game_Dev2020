using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public float restartDelay = 2f;
    public GameObject Truckopen;
    public GameObject Truck;
    public GameObject edge;
    void OnTriggerEnter2D()
    {
        Invoke("tru", restartDelay);
        

    }
    void tru()
	{
        Truck.SetActive(true);
        Truckopen.SetActive(false);
        edge.SetActive(false);
    }
}
