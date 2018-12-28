using UnityEngine;
using System.Collections;

public class HelicopterMovement : MonoBehaviour {

    // http://answers.unity3d.com/questions/690884/how-to-move-an-object-along-x-axis-between-two-poi.html accessed 24th december, published 20th april 2014


    // Use this for initialization
    void Start () {
	
	}


    private bool dirRight = true;
    public float speed = 2.0f;

    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 5.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -5)
        {
            dirRight = true;
        }
    }
}
