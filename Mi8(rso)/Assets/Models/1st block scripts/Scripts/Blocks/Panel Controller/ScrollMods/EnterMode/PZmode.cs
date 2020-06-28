using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PZmode : MonoBehaviour, IEnterMode
{

    public string GetDescription()
    {
        string description = "Режим ПЗ";
        return description;

    }

    public float GetRotateAngle()
    {
        return 130;
    }
}
