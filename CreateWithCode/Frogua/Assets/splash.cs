using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public GameObject splashey;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wa")
		{
            splashey.SetActive(true);
        }
            
    }
    void OnTriggerExit2D(Collider2D other)
	{
        if (other.tag == "Wa")
		{
            splashey.SetActive(false);
        }
            
	}
}
