using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScrollBtn : ScrollButton {


    private IRadioMode[] modes = {new UKV1mode(),new KVmode(),new UKV2mode(),new REZ1(),new REZ2()};
    private IRadioMode currentMode;

    private void Start()
    {
     
        currentMode = ControllPanel().Do().GetRadioMode();
        currentMode =new UKV1mode();
        ControllPanel().Do().SetScreenRadioMode(ControllPanel().Do().GetRadioMode().GetDescription());
    
    }

    private void Update()
    {
        currentMode = ControllPanel().Do().GetRadioMode();
        ScrollButtonRotate(currentMode.GetRotateAngle());
    
    }

    public override string GetDescription()
    {
        string description = "Нижняя ручка сдвоенного поворотного переключателя";
        return description;
    }

    public override void Scroll()
    {
        currentMode = ControllPanel().Do().GetRadioMode();
        if (currentMode != null)
        {
            for (int i = 0; i < modes.Length; i++)
            {
                if (modes[i].GetType() == currentMode.GetType())
                {
                    if (i < modes.Length - 1)
                    {
                        ControllPanel().Do().SetRadioMode(modes[i + 1]);
                       
                    }
                    else if (i >= modes.Length - 1)
                    {
                        ControllPanel().Do().SetRadioMode(modes[0]);
                    }
                    ShowCurrentMode();
                }
            }
        }
        else Debug.Log("Установите значение для Radio");

        ControllPanel().Do().SetScreenRadioMode(ControllPanel().Do().GetRadioMode().GetDescription());
    }

    public override void ShowCurrentMode()
    {
        WindowsSystem.Do().ShowShortDecription("Режим нежней ручки сдвоенного поворотного переключателя установлен в:" + ControllPanel().Do().GetRadioMode().GetDescription());
    }

 
}
