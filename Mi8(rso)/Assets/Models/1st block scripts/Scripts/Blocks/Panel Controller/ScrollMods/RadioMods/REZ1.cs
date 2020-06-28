using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REZ1 : MonoBehaviour,IRadioMode {
    public string GetDescription()
    {
        string description = "Режим РЕЗ1";
        return description;
    }

    public float GetRotateAngle()
    {
        return 160;
    }
}
