using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterScrollBtn : ScrollButton
{

    private IEnterMode[] modes = { new PRDUmode(),new PZmode(),new KANALmode(),new CHASTmode(),new MSHmode(),new USTANmode() };
    private IEnterMode currentMode;

    void Start () {
       
    }
	
	
	void Update () {
        currentMode = ControllPanel().Do().GetEnterMode();
        ScrollButtonRotate(currentMode.GetRotateAngle());
    }


    public override string GetDescription()
    {
        string description = "Нижняя ручка сдвоенного поворотного переключателя";
        return description;
    }

    public override void Scroll()
    {
        currentMode = ControllPanel().Do().GetEnterMode();
        if (currentMode != null)
        {
            for (int i = 0; i < modes.Length; i++)
            {
                if (modes[i].GetType() == currentMode.GetType())
                {
                    if (i < modes.Length - 1)
                    {
                        ControllPanel().Do().SetEnterMode(modes[i + 1]);

                    }
                    else if (i >= modes.Length - 1)
                    {
                        ControllPanel().Do().SetEnterMode(modes[0]);
                    }
                    ShowCurrentMode();
                }
            }
        }
        else Debug.Log("Установите значение для Radio");
        ScrollButtonRotate(currentMode.GetRotateAngle());
       
    }

    public override void ShowCurrentMode()
    {
        WindowsSystem.Do().ShowShortDecription("Режим нежней ручки сдвоенного поворотного переключателя установлен в:" + ControllPanel().Do().GetEnterMode().GetDescription());
    }

  
}
