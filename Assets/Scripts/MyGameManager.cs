using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject player;

    public GameObject mainCanvas;

    public GameObject gameOverCanvas;
    private Health healthPlayer;

    public enum GameStates
    {
        Playing,
        GameOver
    }

    public GameStates gameState = GameStates.Playing;
    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }

        healthPlayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        // State Machine of the game
        switch (gameState)
        {
            case GameStates.Playing:

                if (!healthPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }

                break;
        }
    }
}
