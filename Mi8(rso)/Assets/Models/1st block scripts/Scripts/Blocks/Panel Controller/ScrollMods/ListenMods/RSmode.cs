using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RSmode : MonoBehaviour,IListenMode {

    public string GetDescription()
    {
        string description = "Режим РС";
        return description;

    }

    public float GetRotateAngle()
    {
        return 100;
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
