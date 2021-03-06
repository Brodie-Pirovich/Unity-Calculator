using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoryLogControl : MonoBehaviour
{
    [SerializeField]
    private GameObject textemp;
    private List<GameObject> textItems;

    private void Start()
    {
        textItems = new List<GameObject>();
    }

    public void logText(string text, Color colour)
    {
        if(textItems.Count == 10)
        {
            GameObject tempItem = textItems[0];
            Destroy(tempItem.gameObject);
            textItems.Remove(tempItem);
        }

        GameObject newText = Instantiate(textemp) as GameObject;
        newText.SetActive(true);
        newText.GetComponent<LogItem>().setText(text, colour);
        newText.transform.SetParent(textemp.transform.parent, false);

        textItems.Add(newText.gameObject);
    }

}
