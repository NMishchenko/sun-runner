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
