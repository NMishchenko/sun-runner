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
    private TextAnim NameTextBox;
    private TextAnim DescriptionTextBox;

    void Start()
    {
        NameTextBox = GameObject.FindGameObjectWithTag("Name").GetComponent<TextAnim>();
        DescriptionTextBox = GameObject.FindGameObjectWithTag("Description").GetComponent<TextAnim>();
    }

    public void SelectPart()
    {
        NameTextBox.Text = Name;
        DescriptionTextBox.Text = Description;
        IsSelected = true;

    }
}
