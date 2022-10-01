using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextAnim : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textMeshPro;
    [SerializeField]
    float timeBtwnChars;

    public string Text;

    void Update()
    {
        if (Text != textMeshPro.text)
        {
            PrintText();
        }
    }

    private void PrintText()
    {
        textMeshPro.text = Text;
        StartCoroutine(TextVisible());
    }

    private IEnumerator TextVisible()
    {
        bool IsTyping = true;
        textMeshPro.ForceMeshUpdate();
        int totalVisibleCharacter = textMeshPro.textInfo.characterCount;
        int counter = 0;

        while(IsTyping)
        {
            int visibleCount = counter % (totalVisibleCharacter + 1);
            textMeshPro.maxVisibleCharacters = visibleCount;

            if (visibleCount >= totalVisibleCharacter)
                IsTyping = false;

            counter++;
            yield return new WaitForSeconds(timeBtwnChars);
        }
    }
}
