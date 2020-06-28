using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNUMode : MonoBehaviour,IListenMode
{
    public string GetDescription()
    {
        string description = "В режим РНУ ";
        return description;
    }

    public float GetRotateAngle()
    {
      
        return 180f;
    }


}
