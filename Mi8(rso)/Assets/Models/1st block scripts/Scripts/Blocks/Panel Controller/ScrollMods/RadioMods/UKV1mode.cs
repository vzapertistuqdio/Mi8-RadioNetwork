using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UKV1mode : MonoBehaviour,IRadioMode {
    public string GetDescription()
    {
        string description = "Режим УКВ1";
        return description;
    }

    public float GetRotateAngle()
    {
        return 70;
    }
}
