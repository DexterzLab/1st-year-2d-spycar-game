using UnityEngine;
using System.Collections;

public class Lazer_Prefab : MonoBehaviour {

    /* Unitys method which is automatically called 
 * when an object leave the screen */

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Tank" || col.tag == "enemy1" || col.tag == "enemy2" || col.tag == "Helicopter")
        {
            Destroy(gameObject);
        }
    }
}
