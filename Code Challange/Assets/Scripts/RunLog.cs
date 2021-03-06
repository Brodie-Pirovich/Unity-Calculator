using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunLog : MonoBehaviour
{
    [SerializeField]
    public string myText;

    [SerializeField]
    private Color myColor;

    [SerializeField]
    private HistoryLogControl logControl;

    public void LogText()
    {
        logControl.logText(myText, myColor);
    }

}
