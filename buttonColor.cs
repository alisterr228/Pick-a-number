using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonColor : MonoBehaviour
{
    // Update is called once per frame
    private void Start()
    {
        gameObject.GetComponent<Image>().color = RandomColor();
    }

    Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        float a = 255.0f;
        return new Color(r, g, b, a);
    }
}
