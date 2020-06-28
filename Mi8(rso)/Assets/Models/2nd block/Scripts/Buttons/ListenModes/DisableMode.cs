using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMode : MonoBehaviour,IListenMode
{
    public string GetDescription()
    {
        string description = "В режим ОТКЛ ";
        return description;
    }

    public float GetRotateAngle()
    {      
        return 50f;
        Debug.Log("kek");
    }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
