using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public Transform fakeParent;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = fakeParent.position;
    }
}
