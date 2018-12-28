using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {

    // http://answers.unity3d.com/questions/690884/how-to-move-an-object-along-x-axis-between-two-poi.html accessed 24th december, published 20th april 2014

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame

    private bool dirRight = true;
    public float speed = 2.0f;

    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        else
        {
            transform.Translate(-Vector2.down * speed * Time.deltaTime);
        }

        if (transform.position.y >= 5.0f)
        {
            dirRight = false;
            speed = 0;
        }

        if (transform.position.y <= -5)
        {
            dirRight = true;
        }

    }
}
