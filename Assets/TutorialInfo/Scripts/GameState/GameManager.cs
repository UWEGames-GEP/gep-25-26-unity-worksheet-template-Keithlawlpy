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
        currentState.UpdateState();
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

}
