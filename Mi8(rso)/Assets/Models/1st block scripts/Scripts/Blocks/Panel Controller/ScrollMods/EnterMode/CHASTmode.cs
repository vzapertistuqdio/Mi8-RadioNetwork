using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHASTmode : MonoBehaviour,IEnterMode {

    public string GetDescription()
    {
        string description = "Режим ЧАСТ";
        return description;

    }

    public float GetRotateAngle()
    {
        return 190;
    }
}
