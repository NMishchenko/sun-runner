using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    public GameObject SelectedPiece;
    int OrderInLayer = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if ((hit.transform.CompareTag("Puzzle") || hit.transform.CompareTag("Starter"))
                && !hit.transform.GetComponent<PiecesScript>().IsInRightPosition)
            {
                SelectedPiece = hit.transform.gameObject;
                SelectedPiece.GetComponent<PiecesScript>().IsSelected = true;
                SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OrderInLayer;
                OrderInLayer++;
            }
        }

        if (Input.GetMouseButtonUp(0) && SelectedPiece != null)
        {
            SelectedPiece.GetComponent<PiecesScript>().IsSelected = false;
            SelectedPiece = null;
        }

        if (SelectedPiece != null && SelectedPiece.GetComponent<PiecesScript>().IsInStartPosition)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
