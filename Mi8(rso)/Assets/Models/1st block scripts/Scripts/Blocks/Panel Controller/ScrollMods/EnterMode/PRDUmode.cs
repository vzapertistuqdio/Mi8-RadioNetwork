using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRDUmode : MonoBehaviour, IEnterMode
{

    public string GetDescription()
    {
        string description = "Режим ПРДУ";
        return description;

    }

    public float GetRotateAngle()
    {
        return 100;
    }
}
