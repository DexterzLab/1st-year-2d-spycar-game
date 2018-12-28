using UnityEngine;
using System.Collections;

public class Helicoptercontrol : MonoBehaviour {

    //https://www.youtube.com/watch?v=me4fLBN3_0U&index=8&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0 Accessed 13th November, published 3rd March
    //https://www.youtube.com/watch?v=iTHEXMF0hpc&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0&index=6 Accessed 23rd December, published 25th Feb

    GameObject scoreUIText_obj; //score text that is assigned
    float Heli_Lives = 5;

    // Use this for initialization
    void Start()
    {
        //Get the score text UI
        scoreUIText_obj = GameObject.FindGameObjectWithTag("ScoreTextTag");
    }

    // when the enemy hits the players bullets
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "lazer tag")
        {
            scoreUIText_obj.GetComponent<GameScore>().Score += 200; // add score after being 
            Heli_Lives--; //decrease lives by 1 
            
        }
    }

    // Update is called once per frame
    void Update()
    {

        //SPAWN POINTS
        //this is the top right point of the screen 
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        // if the enemy leaves the screen at the bottom of the screen, the enemy is destroyed
        if (transform.position.y > max.y)
        {
            Destroy(gameObject);
        }

        if (Heli_Lives == 0)
        {
            Destroy(gameObject);
        }
    }
}
