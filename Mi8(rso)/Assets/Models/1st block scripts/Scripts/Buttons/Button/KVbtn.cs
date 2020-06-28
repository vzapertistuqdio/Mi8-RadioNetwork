using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KVbtn :Button {

    

    public override string GetDescription()
    {

        string description = "Кнопка включения КВ радиостанции";
        return description;
    }


    public override void On()
    {
        WindowsSystem.Do().ShowShortDecription("Радиостанция переключена в режим КВ");
        ControllPanel().Do().SetRadiostation(new KVRadiostation());
        PlayAnimation();
    }
}
