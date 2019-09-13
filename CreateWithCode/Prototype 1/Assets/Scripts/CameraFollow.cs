using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{ 
private Vector3 offset = new Vector3(0, 9, -17);


    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
