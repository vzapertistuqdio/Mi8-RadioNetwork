using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSHUKV1btn : Button{

    private bool isOn = false;


    public override string GetDescription()
    {

        string description = "Кнопка включения подавителя шумов УКВ-1 радиостанции";
        return description;
    }

    public override void On()
    {
        if (ControllPanel().Do().GetRadiostation().GetType() == typeof(UKV1Radiostation))
        {
            if (isOn == false)
            {
                WindowsSystem.Do().ShowShortDecription("Подавитель шумов УКВ-1 радиостанции включен");
                isOn = true;
            }
            else if (isOn)
            {
                WindowsSystem.Do().ShowShortDecription("Подавитель шумов УКВ-1 радиостанции выключен");
                isOn = false;
            }
        }
        else WindowsSystem.Do().ShowShortDecription("Подавитель шумов не включен.Радиостанция работает в другом режиме");
        PlayAnimation();
    }
}
