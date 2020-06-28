using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpWindow : Windows{

    public HelpWindow(GameObject windowObj) : base(windowObj)
    {
    }
    public override void On()
    {
        base.On();
        WindowsSystem.Do().EnableChooseModeWindow();
        
    }
    public override void Off()
    {
        base.Off();
        WindowsSystem.Do().DisableChooseModeWindow();
    }
}
