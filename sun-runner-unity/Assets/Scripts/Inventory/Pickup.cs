using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;

    public void PickupItem()
    {
        inventory.SetSlot(gameObject);
        Destroy(gameObject);
    }
}
