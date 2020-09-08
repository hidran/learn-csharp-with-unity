using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GameState{
    menu,
    inTheGame,
    gameOver
}
public class GameManager : MonoBehaviour
{
    public GameState currentGameState = GameState.menu;
    public static GameManager sharedInstance;

    void Awake()
    {
        sharedInstance = this;
    }
    public void Start()
    {
        currentGameState = GameState.menu;
    }
    // Start is called before the first frame update
    void StartGame()
    {
       
        PlayerController.sharedInstance.StartGame();
        ChangeGameState(GameState.inTheGame);

    }
    private void Update()
    {
        if (currentGameState!= GameState.inTheGame && Input.GetButtonDown("s"))
        {
            StartGame();
        }
    }
    // Update is called once per frame
   public void GameOver()
    {
        ChangeGameState(GameState.gameOver);
    }
    void BackToMenuMenu()
    {
        ChangeGameState(GameState.gameOver);

    }
    void ChangeGameState(GameState newGameState)
    {
        switch (newGameState)
        {
            case GameState.menu:
                break;
            case GameState.inTheGame:
                break;
            case GameState.gameOver:
                break;
        }
        currentGameState = newGameState;
    }
}
