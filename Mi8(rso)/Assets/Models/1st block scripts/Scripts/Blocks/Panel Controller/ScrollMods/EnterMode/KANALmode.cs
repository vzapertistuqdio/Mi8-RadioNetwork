using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KANALmode : MonoBehaviour, IEnterMode
{

    public string GetDescription()
    {
        string description = "Режим КАНАЛ";
        return description;

    }

    public float GetRotateAngle()
    {
        return 160;
    }
}
