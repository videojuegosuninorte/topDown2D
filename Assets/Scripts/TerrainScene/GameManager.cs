using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameStateEnum gameState;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateGameState(GameStateEnum gameStateEnum)
    {
        gameState = gameStateEnum;
    }

    void Update()
    {
        switch (gameState)
        {
            case GameStateEnum.start:
                break;
            case GameStateEnum.end:
                break;
        }

    }

public enum GameStateEnum
{
    start,
    end
}
