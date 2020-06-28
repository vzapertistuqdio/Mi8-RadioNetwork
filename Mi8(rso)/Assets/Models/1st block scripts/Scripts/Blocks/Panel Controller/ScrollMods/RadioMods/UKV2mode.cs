using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UKV2mode : MonoBehaviour, IRadioMode {
    public string GetDescription()
    {
        string description = "Режим УКВ2";
        return description;
    }


    public float GetRotateAngle()
    {
        return 130;
    }
}

