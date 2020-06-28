using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UKV2btn : Button
{
    
    public override string GetDescription()
    {

        string description = "Кнопка включения УКВ-2 радиостанции";
        return description;
    }

    public override void On()
    {
        WindowsSystem.Do().ShowShortDecription("Радиостанция переключена в режим УКВ-2");
        ControllPanel().Do().SetRadiostation(new UKV2Radiostation());
        PlayAnimation();
    }
}
