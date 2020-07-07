using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class marjorieFade : MonoBehaviour
{
    public void FadeMeOut()
    {
        StartCoroutine(fadeOut());
    }

    IEnumerator fadeOut()
    {
        yield return StartCoroutine(DoFade());
        /*yield return new WaitForSeconds(2);*/
        yield return StartCoroutine(Offing());
    }


    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 1;
            yield return null;

        }
        canvasGroup.interactable = false;
    }


    IEnumerator Offing()
    {
        yield return null;
        FindObjectOfType<marjorieGrave>().Off();
    }




    public void FadeMeIn()
    {
        StartCoroutine(DoFadeIn());
    }




    IEnumerator DoFadeIn()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / 2;
            yield return null;

        }
        canvasGroup.interactable = false;
    }

}