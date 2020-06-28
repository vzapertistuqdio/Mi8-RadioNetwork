using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseModeWindow : Windows {

    public ChooseModeWindow(GameObject windowObj) : base(windowObj)
    {
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
    public void LoadTheori()
    {
        SceneManager.LoadScene("TheoriScene");
    }
    public void LoadTest()
    {
        SceneManager.LoadScene("TestScene");
    }

}
