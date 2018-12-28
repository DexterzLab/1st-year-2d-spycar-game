using UnityEngine;
using System.Collections;

public class LAZER : MonoBehaviour {

    // University session learning shooting basic, 17th oct
 

    /* Create an instance of the prefab so 
     * it can be instantiated multipel times when the player shoots */
    public Rigidbody lazer_prefab;

    /* The speed that the lazer travels */
    public float lazer_speed = 500f;

    /* the shooting cooldown */
    float shooting_cooldown = 0.1f;

    /* The time the last shot was fired */
    float last_shot = 0.0f; 


    /* Unitys method which is automatically called 
     * when an object leave the screen */

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void fireLazer()
    {
        /* Check the shooting cooldown */
        if (Time.time - last_shot < shooting_cooldown)
        {
            return;
        }

        /* Create an instanceof the lazer prefab */
        Rigidbody lazerPrefab =
            Instantiate(lazer_prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as Rigidbody;

        /* Add a direction to the lazer, here the lazer speed is 
         * added to the Y direction, so the lazer moves up at a speed 
         * of 500 */
        lazerPrefab.GetComponent<Rigidbody>().AddForce(new Vector3(0, lazer_speed));

        /* Finally save the time to the last shot, so that
         * it can be used for checking the cooldown */
        last_shot = Time.time;
    }

    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //XBOX CONTROLS
        if (Input.GetButtonDown("Fire1"))
        {
            fireLazer();
        }

        //COMPUTER CONTROLES
        /*check for input, fire the lazer if the space key is pressed 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fireLazer();
        }*/
    }
}
