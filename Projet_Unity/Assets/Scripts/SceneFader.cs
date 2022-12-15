using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    public Image img;

    public AnimationCurve curve;

    private void Start()
    {
        StartCoroutine(FadeIn());
    }


    public void FadeTo(string scene)
    {
        StartCoroutine(FadeOut(scene));
    }

    //FadeIn = �cran noir vers scene (Disparition de l'�cran noir)
    IEnumerator FadeIn()
    {
        float t = 1f;

        while (t > 0f)
        {
            t -= Time.deltaTime;

            float a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
            //saute une frame : r�duire le temps petit � petit
            yield return 0;
        }
    }

    //FadeOut =  scene vers �cran noir (apparition de l'�cran noir)
    IEnumerator FadeOut(string scene)
    {
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime;

            float a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
            //saute une frame : r�duire le temps petit � petit
            yield return 0;
        }
        // le code ci dessous ne se lit que lorsque le fondu est termin� 
        SceneManager.LoadScene(scene);
    }

}