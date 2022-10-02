using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private Sprite activeSlotSprite;

    [SerializeField]
    private Sprite inactiveSlotSprite;

    public GameObject ActiveSlot { get; private set; }

    public bool[] isFull;
    public GameObject[] slots;

    public void SetSlot(GameObject itemObject)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (isFull[i] == false)
            {
                var slot = slots[i].transform.GetChild(0);
                var slotImage = slot.GetComponent<Image>();
                var itemImage = itemObject.GetComponent<Image>();

                slot.name = itemObject.name;
                slotImage.color = new Color(255, 255, 255, 1);
                slotImage.sprite = itemImage.sprite;

                isFull[i] = true;
                break;
            }
        }
    }

    public void RemoveSlot(string itemName)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].transform.GetChild(0).name == itemName)
            {
                isFull[i] = false;
                var item = slots[i].transform.GetChild(0);
                var itemImage = item.GetComponent<Image>();
                item.name = "Empty";
                itemImage.color = new Color(255, 255, 255, 0);
                itemImage.sprite = null;
                slots[i].GetComponent<Image>().sprite = inactiveSlotSprite;
                ActiveSlot = null;
            }
        }
    }

    public void ActivateSlot(GameObject slotObject)
    {
        if (slotObject.transform.GetChild(0).name == "Empty")
            return;

        DeactivateAllSlots();

        var isSameSlot = slotObject.transform.GetChild(0).gameObject == ActiveSlot;

        ActiveSlot = isSameSlot ? null : slotObject.transform.GetChild(0).gameObject;
        slotObject.GetComponent<Image>().sprite = isSameSlot ? inactiveSlotSprite : activeSlotSprite;
    }

    private void DeactivateAllSlots()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].GetComponent<Image>().sprite = inactiveSlotSprite;
        }
    }
}
