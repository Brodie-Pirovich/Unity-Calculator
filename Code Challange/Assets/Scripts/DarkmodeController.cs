using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkmodeController : MonoBehaviour
{
    public Image[] images;
    public Text[] texts;

    public bool b_isDarkMode = false;

    public void SetDarkMode(bool choice)
    {
        if (choice == true)
        {
            foreach (Image i in images)
            {
                i.color = Color.gray;
            }

            foreach (Text t in texts)
            {
               t.color = Color.white;
            }
        }
        else if (choice == false)
        {
            foreach (Image i in images)
            {
                i.color = Color.white;
            }

            foreach (Text t in texts)
            {
               t.color = Color.black;
            }
        }
        
    }
}
