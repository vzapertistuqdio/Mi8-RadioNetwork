using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenScrollBtnSecond : ScrollButton
{
    private IListenMode[] modes = { new RNUmode(), new DisableMode() };
    private IListenMode currentMode;
    public override string GetDescription()
    {
        string description = "Нижняя ручка сдвоенного поворотного переключателя ";
        return description;
    }

    public override void Scroll()
    {
        currentMode = SecondControllPanel.Do().GetListenMode();
        if (currentMode != null)
        {
            for (int i = 0; i < modes.Length; i++)
            {
                if (modes[i].GetType() == currentMode.GetType())
                {
                    if (i < modes.Length - 1)
                    {
                        SecondControllPanel.Do().SetListenMode(modes[i + 1]);

                    }
                    else if (i >= modes.Length - 1)
                    {
                        SecondControllPanel.Do().SetListenMode(modes[0]);

                    }
                    ShowCurrentMode();
                }
            }
        }
        else Debug.Log("Установите значение для Listen");
    }

    public override void ShowCurrentMode()
    {
        WindowsSystem.Do().ShowShortDecription("Режим нижней ручки сдвоенного поворотного переключателя установлен в: " + SecondControllPanel.Do().GetListenMode().GetDescription());
    }

    private void Start()
    {
        currentMode = SecondControllPanel.Do().GetListenMode();
        currentMode = new DisableMode();
    }

    private void Update()
    {
        currentMode = SecondControllPanel.Do().GetListenMode();
        ScrollButtonRotate(currentMode.GetRotateAngle());
        
    }
}
