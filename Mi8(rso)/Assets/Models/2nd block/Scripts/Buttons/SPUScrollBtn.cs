using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPUScrollBtn : ScrollButton
{
    private float[] values = { 0, 10,20,30,40,50,60,70,80,90,100 };
    private float currentValue;
    public override string GetDescription()
    {
        string description = "Нижняя ручка сдвоенного поворотного переключателя ";
        return description;
    }

    public override void Scroll()
    {
        currentValue = SecondControllPanel.Do().GetSpuValue();
      
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == currentValue)
                {
                    if (i < values.Length - 1)
                    {
                        SecondControllPanel.Do().SetSpuVale(values[i + 1]);

                    }
                    else if (i >= values.Length - 1)
                    {
                        SecondControllPanel.Do().SetSpuVale(values[0]);

                    }
                    ShowCurrentMode();
                }
            }
    }

    public override void ShowCurrentMode()
    {
        WindowsSystem.Do().ShowShortDecription("Значение нижней ручки сдвоенного поворотного переключателя установлено в: " + SecondControllPanel.Do().GetSpuValue());
    }

    
    private void Start()
    {
        
    }

    
    void Update()
    {
        currentValue = SecondControllPanel.Do().GetSpuValue();
        ScrollButtonRotate(190+currentValue);
    }
}
