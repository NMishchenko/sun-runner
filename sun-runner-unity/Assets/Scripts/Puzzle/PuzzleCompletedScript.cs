using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleCompletedScript : MonoBehaviour
{
    public bool IsPuzzleCompleted = false;
    private List<GameObject> piecesToMove;

    void Start()
    {
        piecesToMove = GameObject.FindGameObjectsWithTag("Puzzle").ToList();
    }

    void Update()
    {
        if (!piecesToMove.Exists(p => !p.GetComponent<PiecesScript>().IsInRightPosition))
        {
            SceneManager.LoadScene("ParkerDescription");
        }
    }
}
