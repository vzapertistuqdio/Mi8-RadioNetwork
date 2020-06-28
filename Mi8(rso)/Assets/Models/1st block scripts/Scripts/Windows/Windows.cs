using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Windows : MonoBehaviour {

    public virtual void On()
    {
        windowObj.SetActive(true);
    }
    public virtual void Off()
    {
        windowObj.SetActive(false);
    }
    public GameObject windowObj;

    public Windows(GameObject windowObj)
    {
        this.windowObj = windowObj;
    }
}
