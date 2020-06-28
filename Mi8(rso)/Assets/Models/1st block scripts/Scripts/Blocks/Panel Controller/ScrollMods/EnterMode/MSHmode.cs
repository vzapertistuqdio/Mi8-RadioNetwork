using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSHmode : MonoBehaviour, IEnterMode
{

    public string GetDescription()
    {
        string description = "Режим МШ";
        return description;

    }

    public float GetRotateAngle()
    {
        return 220;
    }
}
