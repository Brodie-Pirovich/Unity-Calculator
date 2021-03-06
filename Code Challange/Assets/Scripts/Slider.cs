using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider : MonoBehaviour
{
    public float minValue = 0;
    public float maxValue = 9;

    public Text minTxt;
    public Text maxTxt;

    public GameObject[] items;

    private void Update()
    {
        UpdateText();

        int max = (int)maxValue;
        int min = (int)minValue;

        for (int i = 0; i <= items.Length-1; i++)
        {
            Debug.Log("i is " + i);
            if (i < min || i > max)
            {
                Debug.Log("Disabling objects!");
                items[i].SetActive(false);
            }
            else
            {
               items[i].SetActive(true);
            }
        }
    }

    public void UpdateText()
    {
        minTxt.text = minValue.ToString();
        maxTxt.text = maxValue.ToString();
    }

    public void SetNewMax(float newVal)
    {
        maxValue = newVal;
    }

    public void SetNewMin(float newVal)
    {
        minValue = newVal;
    }
}
