using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        GAMEPLAY, PAUSE
    }
    public GameState state;
    private bool hasChangedState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = GameState.GAMEPLAY;
    }

    // Update is called once per frame
    void Update()
    {

        switch (state)
        {
            case GameState.GAMEPLAY:

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Debug.Log("Pressed esc one");
                    state = GameState.PAUSE;
                    hasChangedState = true;
                }

                break;

            case GameState.PAUSE:

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Debug.Log("Pressed esc two");
                    state = GameState.GAMEPLAY;
                    hasChangedState = true;
                }

                break;

            default:

                break;
        }

    }

    private void LateUpdate()
    {
        if(hasChangedState)
        {
            hasChangedState = false;

            if(state == GameState.GAMEPLAY)
            {
                Time.timeScale = 1f;
            }
            else if(state == GameState.PAUSE)
            {
                Time.timeScale = 0f;
            }

        }
    }
}
