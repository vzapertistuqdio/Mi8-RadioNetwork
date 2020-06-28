using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KVmode : MonoBehaviour,IRadioMode {
    public string GetDescription()
    {
        string description = "Режим КВ";
        return description;
    }

    public float GetRotateAngle()
    {
        return 100;
    }
}
