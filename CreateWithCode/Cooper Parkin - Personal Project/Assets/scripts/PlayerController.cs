﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 60;
    public float xRange = 35;

    private bombs playerControllerScript;
    public GameObject projectilePrefab;



    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponentInChildren<bombs>();
    }

    
    
    // Update is called once per frame
    void Update()

    {
        if (playerControllerScript.gameOver == true)
        {
            Cursor.visible = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (playerControllerScript.gameOver == false)
        {
            //Cursor.visible = false;
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

            horizontalInput = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Cursor.visible = true;

            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                // Launch a projectile from the player
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }

        }

    }
}
