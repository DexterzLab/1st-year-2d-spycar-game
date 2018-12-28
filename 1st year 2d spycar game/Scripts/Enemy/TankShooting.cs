using UnityEngine;
using System.Collections;

public class TankShooting : MonoBehaviour {

    // https://www.youtube.com/watch?v=rQXvDDoXvLo&index=5&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0 accessed 20th December 2016, published 20th Febraury 2015
    // https://www.youtube.com/watch?v=1mw1ufZq1N4&list=PLbghT7MmckI4IeNHkPm5bFJhY9GQ0anKN&index=5 accessed 2nd january 2016, published 15th november 2014

    public GameObject tank_bullet;

    public float fireDelay = 0.50f;
    float cooldownTimer = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            FireEnemyBullet();
          
        }
	}

    //Function to fire th enemy bullet
    void FireEnemyBullet()
    {
        //get a referance to the players ship
        GameObject playerCar = GameObject.Find("spy car");

        if (playerCar != null) // if the car is not dead
        {
            //instantiate(spawn) the enemy bullet 
            GameObject bullet = (GameObject)Instantiate(tank_bullet);

            //set the bullets initial position
            bullet.transform.position = transform.position;

            //compute the bullets directio towards the player's ship
            Vector2 direction = playerCar.transform.position - bullet.transform.position;

            //set the bullet's direction
            bullet.GetComponent<EnemyBulletScript>().SetDirection(direction);
        }
    }
}
