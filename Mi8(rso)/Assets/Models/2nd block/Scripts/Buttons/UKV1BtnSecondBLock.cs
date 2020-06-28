using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UKV1BtnSecondBLock : Button,IPushContinous
{
    private bool isOn = false;
    [SerializeField] private ParticleSystem greenLight;
    public override string GetDescription()
    {
        string description = "Кнопка включения УКВ-1 радиостанции";
        return description;
    }

    public override void On()
    {
        greenLight.Play();
        PlayAnimation();
        isOn = true;
    }

    public void PushContin()
    {
        On();
    }

    public override void PlayAnimation()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isPushed", true);
    }
    private void Start()
    {
        
    }


    private void Update()
    {
        isOn = false;
        animator.SetBool("isPushed", false);
        if (!isOn)
        {
            greenLight.Stop();
        }
    }
}
