using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogItem : MonoBehaviour
{
    public void setText(string myText, Color myColor)
    {
        GetComponent<Text>().text = myText;
        GetComponent<Text>().color = myColor;
    }
}
