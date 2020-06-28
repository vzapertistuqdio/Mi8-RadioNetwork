using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VSmode : MonoBehaviour,IListenMode {

    public string GetDescription()
    {
        string description = "Режим ВС";
        return description;

    }

    public float GetRotateAngle()
    {
        return 70;
    }

    void Start () {
		
	}
	
	
	void Update () {
		
	}
}
