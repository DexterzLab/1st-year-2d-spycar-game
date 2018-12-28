using UnityEngine;
using System.Collections;

public class GameConsole : MonoBehaviour {

    // https://www.youtube.com/watch?v=W2PgQgLJZ7w&index=7&list=PLRN2Qvxmju0Mf1GB1hXsT-x1GQJQ0pwE0 accessed 13th november 2016, published 28th february 2015


    //referance to our game obejcts
    public GameObject playerCar;
    public GameObject playButton;

    public enum GameConsoleState
    {
        Opening,
        Gameplay,
        GameOver,
    }

    GameConsoleState GCState;

    // Use this for initialization
    void Start () {
        GCState = GameConsoleState.Opening;
	
	}
	
	// Function to update the game console state
	void UpdateGameConsoleState () {
        switch (GCState)
        {
            case GameConsoleState.Opening:

                break;
            case GameConsoleState.Gameplay:
                //hide button when game starts
                playButton.SetActive(false);

                playerCar.GetComponent<Movement>().Init();

                break;
            case GameConsoleState.GameOver:

                break;

        }
	
	}
    // Function to set the game manager state
    public void SetGameConsoleState(GameConsoleState state)
    {
        GCState = state;
        UpdateGameConsoleState();
    }
    /*our play button will call this function
     * when the user clicks the button */
    public void StartGamePlay()
    {
        GCState = GameConsoleState.Gameplay;
        UpdateGameConsoleState();
    }
}
