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
        
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Play State");
    }
}
