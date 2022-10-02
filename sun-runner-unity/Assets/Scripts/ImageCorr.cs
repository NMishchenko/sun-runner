using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageCorr : MonoBehaviour
{
    [SerializeField]
    private Image image;
    public float antiSpeed = 1;
    public float timeToShow = 10;
    void Start()
    {
        StartCoroutine(ShowText());
    }

    public IEnumerator ShowText()
    {
        StartCoroutine(FadeTextToFullAlpha(image));
        yield return new WaitForSeconds(timeToShow);
        StartCoroutine(FadeTextToZeroAlpha(image));
    }

    public IEnumerator FadeTextToFullAlpha(Image i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / antiSpeed));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(Image i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / antiSpeed));
            yield return null;
        }
    }
}
