using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class PartScript : MonoBehaviour
{
    public string Name;
    [TextArea]
    public string Description;
    public bool IsSelected;
    private List<GameObject> parts;
    private TextAnim NameTextBox;
    private TextAnim DescriptionTextBox;

    void Start()
    {
        parts = GameObject.FindGameObjectsWithTag("Part").ToList();
        NameTextBox = GameObject.FindGameObjectWithTag("Name").GetComponent<TextAnim>();
        DescriptionTextBox = GameObject.FindGameObjectWithTag("Description").GetComponent<TextAnim>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.transform.CompareTag("Part") && !hit.transform.GetComponent<PartScript>().IsSelected)
            {
                var SelectedPiece = hit.transform.gameObject;
                SelectedPiece.GetComponent<PartScript>().IsSelected = true;
                SelectedPiece.GetComponent<PartScript>().SelectPart();
            }
        }
    }

    public void SelectPart()
    {
        foreach (GameObject part in parts)
        {
            part.GetComponent<PartScript>().IsSelected = false;
        }
        NameTextBox.Text = Name;
        DescriptionTextBox.Text = Description;
        IsSelected = true;

    }
}
