using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UKV1btn : Button
{

    public override string GetDescription()
    {
        
        string description = "Кнопка включения УКВ-1 радиостанции";
        return  description;
    }

    public override void On()
    {
        WindowsSystem.Do().ShowShortDecription("Радиостанция переключена в режим УКВ-1");
        ControllPanel().Do().SetRadiostation(new UKV1Radiostation());
        PlayAnimation();
    }
}
