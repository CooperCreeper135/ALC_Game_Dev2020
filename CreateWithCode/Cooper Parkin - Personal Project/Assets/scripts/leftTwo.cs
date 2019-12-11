using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftTwo : MonoBehaviour
{
    public float speed;
    private bombs playerControllerScript;
    private float leftBound = -670;
    public bool grnd;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponentInChildren<bombs>();
    }

    // Update is called once per frame
    void Update()
    {

        // If game is not over, move to the left
        if (playerControllerScript.gameOver == false && grnd)
        {

            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            grnd = true;
        }


    }
}
