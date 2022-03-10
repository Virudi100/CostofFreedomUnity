using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartDemo : MonoBehaviour
{
    [SerializeField] private GameObject title;
    [SerializeField] private GameObject subTitle;
    private float alphaIndex = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        title.GetComponent<Text>().color = new Color(255, 255, 255, 0);
        subTitle.GetComponent<Text>().color = new Color(255, 255, 255, 0);
        StartCoroutine(FadeTextToFullAlpha(alphaIndex,title.GetComponent<Text>()));
    }

    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        StartCoroutine(FadeTextToFullAlphaSub(alphaIndex,subTitle.GetComponent<Text>()));
    }

    public IEnumerator FadeTextToFullAlphaSub(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);

        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }

        StartCoroutine(Refade(alphaIndex, title.GetComponent<Text>()));
        StartCoroutine(RefadeSub(alphaIndex, subTitle.GetComponent<Text>()));
    }

    public IEnumerator Refade(float t, Text i)
    { 
        while (i.color.a > 0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator RefadeSub(float t, Text i)
    {
        while (i.color.a > 0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(1);
    }
}
