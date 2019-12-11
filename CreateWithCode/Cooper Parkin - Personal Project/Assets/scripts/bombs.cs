using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombs : MonoBehaviour
{
    
    public ParticleSystem explosionParticle;
    private PlayerController playerControllerScript;
    public bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        //playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            Destroy(other.gameObject);
            gameOver = true;
            Debug.Log("Game Over!");
        }
            

    }
}
