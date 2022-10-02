using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    private List<GameObject> parts;

    void Start()
    {
        parts = GameObject.FindGameObjectsWithTag("Part").ToList();
    }

    public void TryToExit()
    {
        if (!parts.Exists(p => !p.GetComponent<PartScript>().IsSelected))
        {
            SceneManager.LoadScene("StoryThree");
        }
    }
}
