using UnityEngine;
using System.Collections;

public class HelicopterBullet : MonoBehaviour {

    //https://www.youtube.com/watch?v=1mw1ufZq1N4 accessed 8th january 2017, published november 15th 2014

    public float Speed = 5f;
	
	// Update is called once per frame
	void Update () {

        //get the bullets current position 
        Vector3 pos = transform.position;

        //compute the bullets new direction
        Vector3 velocity = new Vector3(0, Speed * Time.deltaTime, 0);


        //update the bullets position
        pos += transform.rotation * velocity;

        transform.position = pos;

        //Removing the bullet when it exits the screen 
        // bottom left of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        //top-right point of the screen
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        //if the bullet exits the screen, destroy it
        if ((transform.position.x < min.x) || (transform.position.x > max.x) ||
            (transform.position.y < min.y) || (transform.position.y > max.y))
        {
            Destroy(gameObject);
        }

    }

    //COLLIDER
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
