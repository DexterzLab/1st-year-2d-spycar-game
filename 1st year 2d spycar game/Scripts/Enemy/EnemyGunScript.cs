using UnityEngine;
using System.Collections;

public class EnemyGunScript : MonoBehaviour {

    // https://www.youtube.com/watch?v=rQXvDDoXvLo&index=5&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0 accessed 20th December 2016, published 20th Febraury 2015

    public GameObject EnemyBullet_obj; //the assigned bullet game object



	// Use this for initialization
	void Start () {

        //fire an enemy bullet after 1 second
        Invoke ("FireEnemyBullet", 1f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Function to fire th enemy bullet
    void FireEnemyBullet()
    {
        //get a referance to the players ship
        GameObject playerCar = GameObject.Find("spy car");

        if(playerCar != null) // if the car is not dead
        {
            //instantiate(spawn) the enemy bullet 
            GameObject bullet = (GameObject)Instantiate(EnemyBullet_obj);

            //set the bullets initial position
            bullet.transform.position = transform.position;

            //compute the bullets directio towards the player's ship
            Vector2 direction = playerCar.transform.position - bullet.transform.position;

            //set the bullet's direction
            bullet.GetComponent<EnemyBulletScript>().SetDirection(direction);
        }
    }
}
