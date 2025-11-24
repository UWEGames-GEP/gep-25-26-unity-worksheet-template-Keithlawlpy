using UnityEngine;

public class PauseState : BaseGameState
{
    GameManager manager;

    public PauseState(GameManager manager) : base(manager) 
    {
        this.manager = manager;
    }

    public override void EnterState()
    {
        
        Debug.Log("Entered Pause State");
        Time.timeScale = 0f;
        manager.GameUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    public override void UpdateState()
    {
       
    }

    public override void LateUpdate()
    {   

    }

    public override void ExitState()
    {
        Debug.Log("Exiting Pause State");
    }
}
