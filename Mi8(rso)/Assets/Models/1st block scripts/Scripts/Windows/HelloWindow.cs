using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWindow : Windows {
    public HelloWindow(GameObject windowObj) : base(windowObj)
    {
    }

    public void SetDescriptionText(string text)
    {
        windowObj.GetComponentInChildren<Text>().text = text;
    }
    public override void On()
    {
        base.On();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public override void Off()
    {
        base.Off();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
