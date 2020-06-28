using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenScrollbtn : ScrollButton {

    

    private IListenMode[] modes = {new VSmode(),new RSmode(),new ARKmode(), new RNUmode() };
    private IListenMode currentMode;                                                         
    

    private void Start()
    {
       
        currentMode = ControllPanel().Do().GetListenMode();
        currentMode = new VSmode();
        ControllPanel().Do().SetScreenListenMode(ControllPanel().Do().GetListenMode().GetDescription());

    }

    private void Update()
    {
        currentMode = ControllPanel().Do().GetListenMode();
        ScrollButtonRotate(currentMode.GetRotateAngle());
    }
    public override string GetDescription()
    {
        string description = "Нижняя ручка сдвоенного поворотного переключателя ";
        return description;
    }

    public override void Scroll()
    {
        currentMode = ControllPanel().Do().GetListenMode();
        if (currentMode != null)
        {
            for (int i = 0; i < modes.Length; i++)
            {
                if (modes[i].GetType() == currentMode.GetType())
                {
                    if (i < modes.Length - 1)
                    {
                        ControllPanel().Do().SetListenMode(modes[i + 1]);
                        
                    }
                    else if (i >= modes.Length - 1)
                    {
                        ControllPanel().Do().SetListenMode(modes[0]);
                        
                    }
                    ShowCurrentMode();
                }
            }
        }
        else Debug.Log("Установите значение для Listen");
        ControllPanel().Do().SetScreenListenMode(ControllPanel().Do().GetListenMode().GetDescription());
        
    }

    public override void ShowCurrentMode()
    {
        WindowsSystem.Do().ShowShortDecription("Режим нежней ручки сдвоенного поворотного переключателя установлен в: " + ControllPanel().Do().GetListenMode().GetDescription());
    }

 
}
