using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonDown : MonoBehaviour
{
    public Button buttonVal;
    private NumsLogic nl;

    public int index;
    private static int count;


    public static int PubCount
    {
        get
        {
            return count;
        }
    }

    private void Start()
    {
        nl = GetComponentInParent<NumsLogic>();
        buttonVal.onClick.AddListener(ButtonDown);
    }

    private void ButtonDown()
    {
        if(index >=0 && index < 25)
            count = nl.PubNumsLength[index];
    }
}
