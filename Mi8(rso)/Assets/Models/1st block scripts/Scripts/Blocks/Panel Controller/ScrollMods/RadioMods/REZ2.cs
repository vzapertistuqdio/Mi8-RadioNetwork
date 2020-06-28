using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REZ2 : MonoBehaviour,IRadioMode {
    public string GetDescription()
    {
        string description = "Режим РЕЗ2";
        return description;
    }

    public float GetRotateAngle()
    {
        return 190;
    }
}
