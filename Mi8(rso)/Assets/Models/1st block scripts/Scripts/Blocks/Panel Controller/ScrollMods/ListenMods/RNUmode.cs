using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNUmode : MonoBehaviour,IListenMode {

    public string GetDescription()
    {
        string description = "Режим РНУ";
        return description;

    }

    public float GetRotateAngle()
    {
        return 160;
    }
    void Start () {
		
	}
	
	
	void Update () {
		
	}
}
