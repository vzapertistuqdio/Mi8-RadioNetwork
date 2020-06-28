using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractBtn : Button
{
    public override string GetDescription()
    {
        string description = "Это кнопка";
        return  description;
    }

    public override void On()
    {
        Debug.Log("Кнопка включена");
        PlayAnimation();
    }

  
}
