using UnityEngine;

public class PauseState : BaseGameState
{
    public PauseState(GameManager manager) : base(manager) 
    {

    }

    public override void EnterState()
    {
        Time.timeScale = 0f;
        Debug.Log("Entered Pause State");
    }

    public override void UpdateState()
    {
        
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Pause State");
    }
}
