using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpuChanger : Button
{
    bool isRadioEnable = false;
    bool isSPUEnable = false;
    public override string GetDescription()
    {
        string description = "Переключатель СПУ и РАДИО";
        return description; ;
    }

    public override void On()
    {
       if(isRadioEnable)
        {
            isRadioEnable = false;
            isSPUEnable = true;
            GetComponentInParent<RectTransform>().rotation= Quaternion.Euler(30, 0, 0);
        }
       else if (isSPUEnable)
        {
            isRadioEnable = true;
            isSPUEnable = false;
         GetComponentInParent<RectTransform>().rotation = Quaternion.Euler(-15,0,0);
        }
    }

  
    private void Start()
    {
        isRadioEnable = true;
    }

}
