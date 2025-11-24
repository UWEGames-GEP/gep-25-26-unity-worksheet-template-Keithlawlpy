using UnityEngine;

public class PlayState : BaseGameState
{
    GameManager manager;
    public PlayState(GameManager manager) : base(manager) 
    {
        this.manager = manager;
    }
    public override void EnterState()
    {
        Debug.Log("Entered Play State");
        Time.timeScale = 1f;
        manager.GameUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    public override void UpdateState()
    {
        
    }

    public override void LateUpdate()
    {
        
    }

    public override void ExitState()
    {
        Debug.Log("Exiting Play State");
    }
}
