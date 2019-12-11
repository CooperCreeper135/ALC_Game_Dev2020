using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballz : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private bombs playerControllerScript;

    private float spawnLimitXLeft = -20;
    private float spawnLimitXRight = 15;
    private float spawnPosY = 84;


    private float startDelay = .3f;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponentInChildren<bombs>();
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        if (playerControllerScript.gameOver == false)
        {
            int ballIndex = Random.Range(0, ballPrefabs.Length);
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 57);

            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);
        }

    }

}
