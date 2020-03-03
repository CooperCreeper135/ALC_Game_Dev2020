using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heck : MonoBehaviour
{
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["Rock"].layer = 123;
    }

    // Update is called once per frame
    void Update()
    {
        // leave spin or jump to complete before changing

        anim.Play("Rock");




    }
}

