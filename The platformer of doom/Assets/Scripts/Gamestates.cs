using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gamestates : MonoBehaviour
{
    public StringData gameState;
    public UnityEvent normal, lightsOff, endGame, stateCheck;

    public enum GameStates
    {
        Normal,
        LightsOff,
        Endgame,
    }

    public GameStates currentGameState;
    // Start is called before the first frame update
    public void ChangeStates ()
    {
        if (gameState.value == "normal")
        {
            currentGameState = GameStates.Normal;
        }
        else if (gameState.value == "lightsOff")
        {
            currentGameState = GameStates.LightsOff;
        }
        else if (gameState.value == "endGame")
        {
            currentGameState = GameStates.Endgame;
        }
        else
        {
            print("ya fucked up lad, fix the gamestate");
        }
    }
    
    void Update()
    {
        stateCheck.Invoke();
        switch (currentGameState)
        {
            case GameStates.Normal:
                normal.Invoke();
                break;
            case GameStates.LightsOff:
                lightsOff.Invoke();
                break;
            case GameStates.Endgame:
                endGame.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
