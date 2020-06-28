using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ScrollButton : MonoBehaviour,IControllButton {

    [SerializeField] public GameObject radioControllObject;

    private float AngleValue;
 

    public void Push()
    {
        Scroll();
    }

    public abstract void Scroll();

    public abstract string GetDescription();

    public abstract void ShowCurrentMode();

    public  void ScrollButtonRotate(float angle)
    {
        transform.localRotation = Quaternion.Euler(transform.localEulerAngles.x, transform.localEulerAngles.y, angle);
    }

    public RadiostationControllPanel ControllPanel()
    {
        return radioControllObject.GetComponent<RadiostationControllPanel>();
    }
}
