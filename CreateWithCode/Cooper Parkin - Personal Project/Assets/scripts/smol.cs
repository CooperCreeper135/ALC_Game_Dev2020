using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smol : MonoBehaviour
{
    private bool touched = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (touched == true)
        {
            transform.localScale -= new Vector3(.8f, .8f, .8f);
            if (transform.localScale.x < .1)
            {
                Destroy(gameObject);
            }
        }
        


    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
            touched = true;
    }
}
