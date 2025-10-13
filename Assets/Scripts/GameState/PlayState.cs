using UnityEngine;

public class PlayState : BaseGameState
{
    public PlayState(GameManager manager) : base(manager) 
    { 
    
    }
    public override void EnterState()
    {
        Time.timeScale = 1f;
        Debug.Log("Entered Play State");
    }

    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameManager.ChangeState(new PauseState(gameManager));
        }
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Play State");
    }
}
