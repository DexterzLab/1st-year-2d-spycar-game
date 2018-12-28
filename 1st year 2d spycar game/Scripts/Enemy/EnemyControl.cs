using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

    //https://www.youtube.com/watch?v=me4fLBN3_0U&index=8&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0 Accessed 13th November 2016, published 3rd march 2015

    GameObject scoreUIText_obj; //score text that is assigned

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
            scoreUIText_obj.GetComponent<GameScore>().Score += 100;

            Destroy(gameObject);
            
        }

        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
        
        //SPAWN POINTS
        //this is the top right point of the screen 
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

	    // if the enemy leaves the screen at the bottom of the screen, the enemy is destroyed
        if (transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
	}
}
