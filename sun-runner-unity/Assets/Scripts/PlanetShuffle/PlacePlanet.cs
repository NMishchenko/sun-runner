using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlacePlanet : MonoBehaviour
{
    public bool IsCorrect;
    [SerializeField]
    private Inventory inventory;
    public GameObject currentItem;
    public bool IsPuzzleCompleted = false;
    private List<GameObject> places;

    void Start()
    {
        places = GameObject.FindGameObjectsWithTag("PlaceForShuffling").ToList();
    }

    void Update()
    {
        if (!places.Exists(p => !p.GetComponent<PlacePlanet>().IsCorrect))
        {
            SceneManager.LoadScene("ParkerDescription");
        }
    }

    public void SelectItem(string requiredItemName)
    {
        if (inventory.ActiveSlot is not null && requiredItemName == inventory.ActiveSlot.name)
        {
            IsCorrect = true;
            currentItem = inventory.ActiveSlot;
            var slot = transform.GetChild(0);
            var slotImage = slot.GetComponent<Image>();
            var itemImage = currentItem.GetComponent<Image>();

            slot.name = currentItem.name;
            slotImage.color = new Color(255, 255, 255, 1);
            slotImage.sprite = itemImage.sprite;
            inventory.RemoveSlot(currentItem.name);
        }
    }
}
