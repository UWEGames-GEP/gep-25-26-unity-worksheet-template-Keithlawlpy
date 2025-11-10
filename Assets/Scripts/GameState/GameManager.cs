using System;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    private BaseGameState currentState;

    void Start()
    {
        ChangeState(new PlayState(this));
    }

    void Update()
    {


    }

    public void ChangeState(BaseGameState newState)
    {
        if (currentState != null)
        {
            currentState.ExitState();
        }

        currentState = newState;
        currentState.EnterState();
    }

    public void TogglePause()
    {
        if (currentState is PlayState)
        {
            ChangeState(new PauseState(this));
        }
        else if (currentState is PauseState)
        {
            ChangeState(new PlayState(this));
        }
    }
}
