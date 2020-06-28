using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSHKVbtn : Button {

 

    private bool isOn=false;
    public override string GetDescription()
    {

        string description = "Кнопка включения подавителя шумов КВ радиостанции";
        return description;
    }

    public override void On()
    {        
        if (ControllPanel().Do().GetRadiostation().GetType()==typeof(KVRadiostation))
        {
            if (isOn == false)
            {
                WindowsSystem.Do().ShowShortDecription("Подавитель шумов КВ радиостанции включен");
                isOn = true;
            }
            else if(isOn)
            {
                WindowsSystem.Do().ShowShortDecription("Подавитель шумов КВ радиостанции выключен");
                isOn = false;
            }
        }
        else WindowsSystem.Do().ShowShortDecription("Подавитель шумов не включен.Радиостанция работает в другом режиме");
        PlayAnimation();
    }
    
}
