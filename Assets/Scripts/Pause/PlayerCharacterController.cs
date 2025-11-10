using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharcterController : ThirdPersonController
{

    private void OnPause (InputValue value)
    { 
        if (value.isPressed)
        {
            var gm = Object.FindFirstObjectByType<GameManager>();
            if (gm != null)
            {
                gm.TogglePause();
            }
        }
    }
}
