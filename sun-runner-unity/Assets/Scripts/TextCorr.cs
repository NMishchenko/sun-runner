using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextCorr : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    public float antiSpeed = 1;
    public float timeToShow = 10;
    void Start()
    {
        StartCoroutine(ShowText());
    }

    public IEnumerator ShowText()
    {
        StartCoroutine(FadeTextToFullAlpha(text));
        yield return new WaitForSeconds(timeToShow);
        StartCoroutine(FadeTextToZeroAlpha(text));
    }

    public IEnumerator FadeTextToFullAlpha(TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / antiSpeed));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / antiSpeed));
            yield return null;
        }
    }
}
