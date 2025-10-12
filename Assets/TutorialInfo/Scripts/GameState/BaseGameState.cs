using UnityEngine;

public abstract class BaseGameState
{
    protected GameManager gameManager;

    public BaseGameState(GameManager manager)
    {
        gameManager = manager;
    }

    public virtual void EnterState() { }
    public virtual void UpdateState() { }
    public virtual void ExitState() { }

}
