using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScrollBtnSecond : ScrollButton
{

    private IRadioMode[] modes = { new UKV1mode(),new UKV2mode(),new KVmode() };
    private IRadioMode currentMode;
    public override string GetDescription()
    {
        string description = "Нижняя ручка сдвоенного поворотного переключателя ";
        return description;
    }

    public override void Scroll()
    {
        currentMode = SecondControllPanel.Do().GetRadioMode();
        if (currentMode != null)
        {
            for (int i = 0; i < modes.Length; i++)
            {
                if (modes[i].GetType() == currentMode.GetType())
                {
                    if (i < modes.Length - 1)
                    {
                        SecondControllPanel.Do().SetRadioMode(modes[i + 1]);

                    }
                    else if (i >= modes.Length - 1)
                    {
                        SecondControllPanel.Do().SetRadioMode(modes[0]);
                    }
                    ShowCurrentMode();
                }
            }
        }
        else Debug.Log("Установите значение для Radio");
    }

    public override void ShowCurrentMode()
    {
        WindowsSystem.Do().ShowShortDecription("Режим нежней ручки сдвоенного поворотного переключателя установлен в:" +SecondControllPanel.Do().GetRadioMode().GetDescription());
    }
    private void Start()
    {
        currentMode = SecondControllPanel.Do().GetRadioMode();
        currentMode = new UKV1mode();
    }

    private void Update()
    {
        currentMode = SecondControllPanel.Do().GetRadioMode();
        if(currentMode.GetType()!=typeof(KVmode))
         ScrollButtonRotate(currentMode.GetRotateAngle());
        else ScrollButtonRotate(190);
    }
}
