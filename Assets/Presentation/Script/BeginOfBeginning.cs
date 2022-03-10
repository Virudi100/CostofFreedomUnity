using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginOfBeginning : MonoBehaviour
{
    private float alphaIndex =1f;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        StartCoroutine(FadeTextToNoAlpha(alphaIndex, gameObject.GetComponent<Image>()));
    }

    public IEnumerator FadeTextToNoAlpha(float t, Image i)
    {
        yield return new WaitForSeconds(2);
        while (i.color.a != 0)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
