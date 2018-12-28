using UnityEngine;
using System.Collections;


//https://www.youtube.com/watch?v=k3GN3FuyqnQ&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0&index=4 accessed 13th november, published 18th february 2015
// https://unity3d.com/learn/tutorials/projects/space-shooter-tutorial/game-controller?playlist=17147 accessed 14th november, Published 20th December 2013 

public class EnemySpawner : MonoBehaviour {

    public GameObject Hazard;
    public GameObject Hazard2;
    public GameObject Hazard3;
    public Vector2 SpawnValues; 


    float maxSpawnRateInSeconds = 15f;
    
    // Use this for initialization
    void Start () {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        //Increase spawn rate every 20 seconds.
        InvokeRepeating("IncreaseSpawnRate", 0f, 20f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Function to spawn enemy
    void SpawnEnemy()
    {
        

        //Instantiate an enemy
        GameObject anEnemy = (GameObject)Instantiate(Hazard);
        anEnemy.transform.position = new Vector2(Random.Range(-SpawnValues.x, SpawnValues.x), -SpawnValues.y);
        GameObject anEnemy2 = (GameObject)Instantiate(Hazard2);
        anEnemy2.transform.position = new Vector2(Random.Range(-SpawnValues.x, SpawnValues.x), -SpawnValues.y);
        GameObject anEnemy3 = (GameObject)Instantiate(Hazard3);
        anEnemy3.transform.position = new Vector2(Random.Range(-SpawnValues.x, SpawnValues.x), -SpawnValues.y);

        //Schedule when to spawn the next enemy
        ScheduleNextEnemySpawn();
    }

    void ScheduleNextEnemySpawn()
    {
        float spawnInSeconds;

        if (maxSpawnRateInSeconds > 1f)
        {
            //pick a number between 1 and maxspawnrate
            spawnInSeconds = Random.Range(1f, maxSpawnRateInSeconds);
        }
        else
            spawnInSeconds = 1f;
        Invoke("SpawnEnemy", spawnInSeconds);
    }

    //Function to increase the difficulty of the game
    void IncreaseSpawnRate()
    {
        if (maxSpawnRateInSeconds > 1f)
            maxSpawnRateInSeconds--;

        if (maxSpawnRateInSeconds == 1f)
            CancelInvoke("IncreaseSpawnRate");

    }

}
