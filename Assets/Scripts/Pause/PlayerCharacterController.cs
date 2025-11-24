using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharcterController : ThirdPersonController
{

    private void OnPause (InputValue value)
    { 
        if (value.isPressed)
        {
            Debug.Log("Pause Toggled");
            var gm = Object.FindFirstObjectByType<GameManager>();
            if (gm != null)
            {
                gm.TogglePause();
            }
            
        }
    }

    private void OnRemoveItem (InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Remove Item");
            GetComponent<Inventory>().RemoveItemFromInventory();
        }
    }
}
