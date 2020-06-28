using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USTANmode : MonoBehaviour, IEnterMode
{

    public string GetDescription()
    {
        string description = "Режим УСТАН";
        return description;

    }

    public float GetRotateAngle()
    {
        return 250;
    }
}
