using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;
    [SerializeField]
    private string sceneName;

    public void ChangeScene(string requiredItemName)
    {
        if (!string.IsNullOrEmpty(requiredItemName))
        {
            if (inventory.ActiveSlot is not null && requiredItemName == inventory.ActiveSlot.name)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
