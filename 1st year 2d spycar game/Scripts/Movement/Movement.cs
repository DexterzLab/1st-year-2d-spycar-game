using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movement : MonoBehaviour {
    //https://www.youtube.com/watch?v=W2PgQgLJZ7w&index=7&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0 Accessed 14th november, plublished 28th february 2015

    //Referance to the lives ui text
    public GameObject GameConsole_obj; //referance to the game console
    public Text LivesUIText;
    const int MaxLives = 10;//max player lives
    int lives; //current player lives
    public void Init()
    {
        lives = MaxLives;

        //update the lives Ui text
        LivesUIText.text = lives.ToString();
        
        //set this player game object to active
        gameObject.SetActive(true);
    }

    //COLLIDER
    void OnTriggerEnter (Collider col)
    {
        //detect the collision of the player car
        if (col.tag == "enemy1" || col.tag == "enemyBullet" || col.tag == "enemy2" || col.tag == "Tank" || col.tag == "Heli_Bullet")
        {
            lives--; // subtract one 
            LivesUIText.text = lives.ToString(); //Update the lives 

            if (lives == 0)// if player is dead turn the object off and stop the game
            {
                //change game manager state to game over state
                GameConsole_obj.GetComponent<GameConsole>().SetGameConsoleState(GameConsole.GameConsoleState.GameOver);

                //hide the players ship
                gameObject.SetActive(false);
            }

        }

        

         
    }


    // University session 17th oct 2016 learning movement and collision
    // University session 24th oct 2016 learning xbox controls

    /**
     * This is the bounding size of the ship, this should be half the width and/or height 
     * this is set to public so the value can be changed in the unity editor
     */
    //public float bounding_size = 20.0f;

    /**
     * store a referance to the games camera
     */
    Camera game_camera;

    

	// Use this for initialization
	void Start () {
        game_camera = FindObjectOfType<Camera>();

        
	}
	
	// Update is called once per frame
	void Update () {
       
        //The shipPosition vector will holf the information for the movement of the space ship
        //every frame this number starts 0,0, and will change as a result of keyboard input
        //from the player

        Vector3 ShipPosition = new Vector3(0, 0, 0);
        // Vector3 translation = new Vector3(0, 0, 0); 

        
        //XBOX CONTROLS 

        float speed = Input.GetAxis("Horizontal");
        ShipPosition += new Vector3(speed * 8, 0) * Time.deltaTime;
        speed = Input.GetAxis("Vertical");
        ShipPosition += new Vector3 (0, speed * 8) * Time.deltaTime;



        //PC CONTROLS 



        //the following conditional (if) statements will get the keyboard input from the player
        // it sets the translation of the ship to the right direction
        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ShipPosition = new Vector3(0, 3) * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            ShipPosition = new Vector3(0, -3) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            ShipPosition = new Vector3(-3, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ShipPosition = new Vector3(3, 0) * Time.deltaTime;

        } 
        */



        /* Detect the collision with the camera bounds based upon the sips position
         * if detected, the translation will be set to 0,0 meaning that the 
         * ship will not move */


        /* Vector3 new_position = game_camera.WorldToScreenPoint(transform.position + ShipPosition);

         if (new_position.x + bounding_size >= game_camera.pixelWidth)
         {
             ShipPosition = new Vector3(0, 0, 0);
             }

         else if (new_position.x - bounding_size <= 0)
         {
             ShipPosition = new Vector3(0, 0, 0);
             }

         else if (new_position.y + bounding_size >= game_camera.pixelHeight)
         {
             ShipPosition = new Vector3(0, 0, 0);
             }

         else if (new_position.y - bounding_size <= 0)
         {
             ShipPosition = new Vector3(0, 0, 0);
             } */

        //Apply the translation in order to move the ship 
        transform.Translate(ShipPosition);

        
    }

}
