using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Button : MonoBehaviour,IControllButton {

    public Animator animator;

    [SerializeField] public GameObject radioControllObject;

    public abstract void On();
    public abstract string GetDescription();

    public virtual void PlayAnimation()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isOn",true);
        StartCoroutine(WaitEndAnim(0.3f));
    }
 
    public  void Push()
    {
        On();
    }

    public IEnumerator WaitEndAnim(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        animator.SetBool("isOn", false);
    }

    public RadiostationControllPanel ControllPanel()
    {
        return radioControllObject.GetComponent<RadiostationControllPanel>();
    }
   
}
