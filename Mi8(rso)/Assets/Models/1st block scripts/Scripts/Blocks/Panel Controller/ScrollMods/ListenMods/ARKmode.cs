using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARKmode : MonoBehaviour,IListenMode {

    public string GetDescription()
    {
        string description = "Режим АРК";
        return description;

    }

    public float GetRotateAngle()
    {
        return 130;
    }

    
}
