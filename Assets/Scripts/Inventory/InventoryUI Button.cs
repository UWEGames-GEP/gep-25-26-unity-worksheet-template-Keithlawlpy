using TMPro;
using UnityEngine;

public class InventoryUIButton : MonoBehaviour
{
    public TMP_Text text;

    public void SetButton(ItemObject item)
    {
        text.text = item.itemName;
    }
}
