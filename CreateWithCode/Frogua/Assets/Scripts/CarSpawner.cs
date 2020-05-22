using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = 2f;

    public GameObject car;

    public GameObject pee;

    float nextTimeToSpawn = 0f;

    public Transform[] spawnPoints;

    public Sprite[] carSprite;

    //int carRandomizer = Random.Range(1, 5);

    void Update()
	{
        
        if (nextTimeToSpawn <= Time.time)
		{
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
		}
	}
    void SpawnCar()
	{
        int randomIndex = Random.Range(0, spawnPoints.Length);
        int carRandomizer = Random.Range(0, carSprite.Length);
        car.GetComponent<SpriteRenderer>().sprite = carSprite[carRandomizer];
        Transform spawnPoint = spawnPoints[randomIndex];

        pee = Instantiate(car, spawnPoint.position, spawnPoint.rotation);
        Object.Destroy(pee, 4.0f);
    }
}
