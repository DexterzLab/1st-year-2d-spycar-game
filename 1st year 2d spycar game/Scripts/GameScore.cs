using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScore : MonoBehaviour {

    // https://www.youtube.com/watch?v=me4fLBN3_0U&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0&index=8 accessed 13th Novemeber, published 3rd march

    Text scoreTextUI;

    int score;

    public int Score
    {
        get
        {
            return this.score;
        }
        set
        {
            this.score = value;
            UpdateScoreTextUI();
        }
    }


	// Use this for initialization
	void Start () {

        //get the text UI component of this gameObject
        scoreTextUI = GetComponent<Text>();
	
	}

    //function to update the score text UI
    void UpdateScoreTextUI()
    {
        string scoreStr = string.Format("{0:0000000000}", score);
        scoreTextUI.text = scoreStr;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
