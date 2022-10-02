using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsShufflingCompleted : MonoBehaviour
{
    private List<PlacePlanet> places;

    void Start()
    {
        places = transform.GetComponentsInChildren<PlacePlanet>().ToList();
    }

    void Update()
    {
        if (!places.Exists(p => !p.IsCorrect))
        {
            SceneManager.LoadScene("ParkerDescription");
        }
    }
}
