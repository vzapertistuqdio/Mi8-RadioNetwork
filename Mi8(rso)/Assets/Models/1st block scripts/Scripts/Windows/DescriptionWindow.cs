using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionWindow : Windows
{
    public DescriptionWindow(GameObject windowObj) : base(windowObj)
    {
    }

    public void SetDescriptionText(string text)
    {
        windowObj.GetComponentInChildren<Text>().text = text;
    }
}
