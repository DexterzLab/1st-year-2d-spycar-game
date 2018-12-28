using UnityEngine;
using System.Collections;

public class HelicopterSpawn : MonoBehaviour {


    public GameObject Helicopter_obj;
    public Vector2 SpawnValues;
    float maxSpawnRateInSeconds = 60f;

    // Use this for initialization
    void Start()
    {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Function to spawn enemy
    void SpawnEnemy()
    {
        //Instantiate an enemy
        GameObject anHelicopter = (GameObject)Instantiate(Helicopter_obj);
        anHelicopter.transform.position = new Vector2(SpawnValues.x, SpawnValues.y);
        
        //Schedule when to spawn the next enemy
        ScheduleNextEnemySpawn();
    }

    void ScheduleNextEnemySpawn()
    {
        float spawnInSeconds;

        if (maxSpawnRateInSeconds > 1f)
        {
            //pick a number between 1 and maxspawnrate
            spawnInSeconds = maxSpawnRateInSeconds;
        }
        else
            spawnInSeconds = 1f;
        Invoke("SpawnEnemy", spawnInSeconds);
    }

   
}
