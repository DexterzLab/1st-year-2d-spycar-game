using UnityEngine;
using System.Collections;

public class EnemyBulletScript : MonoBehaviour {

    // https://www.youtube.com/watch?v=rQXvDDoXvLo&index=5&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0 accessed 20th December 2016, published 20th Febraury 2015


    float speed; //the bullet speed
    Vector2 _direction; //the direction of the bullet
    bool isReady; //to know when the bullet direction is set 

    void Awake()
    {
        speed = 5f;
        isReady = false;
    }

	// Use this for initialization
	void Start () {
	
	}

    // Function to set the bullet's direction
    public void SetDirection(Vector2 direction)
    {
        _direction = direction.normalized;

        isReady = true; // set flag to true
    }

    //COLLIDER
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (isReady)
        {
            //get the bullets current position 
            Vector2 position = transform.position;

            //compute the bullets new direction
            position += _direction * speed * Time.deltaTime;

            //update the bullets position
            transform.position = position;

            //Removing the bullet when it exits the screen 
            // bottom left of the screen
            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

            //top-right point of the screen
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

            //if the bullet exits the screen, destroy it
            if((transform.position.x < min.x) || (transform.position.x > max.x) ||
                (transform.position.y < min.y) || (transform.position.y > max.y))
            {
                Destroy(gameObject);
            }

            

        }
	}
}
