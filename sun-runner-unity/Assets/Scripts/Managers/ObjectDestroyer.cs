using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;

    public void Remove(string requiredItemName)
    {
        if (!string.IsNullOrEmpty(requiredItemName))
        {
            if (inventory.ActiveSlot is not null && requiredItemName == inventory.ActiveSlot.name)
            {
                inventory.RemoveSlot(requiredItemName);
                Destroy(gameObject);
            } 
        }
        else
        {
            inventory.RemoveSlot(requiredItemName);
            Destroy(gameObject);
        }
    }
}
