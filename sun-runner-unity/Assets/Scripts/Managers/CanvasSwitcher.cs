using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;
    [SerializeField]
    private Canvas firstCanvas;
    [SerializeField]
    private Canvas secondCanvas;

    public void ChangeCanvas(string requiredItemName)
    {
        if (!string.IsNullOrEmpty(requiredItemName))
        {
            if (inventory.ActiveSlot is not null && requiredItemName == inventory.ActiveSlot.name)
            {
                SwitchCanvas(requiredItemName);
            } 
        }
        else
        {
            SwitchCanvas(requiredItemName);
        }
    }
    
    private void SwitchCanvas(string reqiuredItemName)
    {
        firstCanvas.enabled = false;
        secondCanvas.enabled = true;
        secondCanvas.gameObject.SetActive(true);
        inventory.RemoveSlot(reqiuredItemName);
    }
}
