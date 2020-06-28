using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParametrsWindow : Windows  {

    private Text velocityText;
    private Text heightText;
    private Text psiText;

    public ParametrsWindow(GameObject windowObj,Text velocityText,Text heightText,Text psiText) : base(windowObj)
    {
        this.velocityText = velocityText;
        this.heightText = heightText;
        this.psiText = psiText;
    }
   
    public override void On()
    {
        base.On();    
    }
    public override void Off()
    {
        base.Off();     
    }
    public void SetVelocityText(string text)
    {
        velocityText.text ="Velocity= "+text;
    }
    public void SetHeightText(string text)
    {
        heightText.text = "Height= " + text;
    }
    public void SetPsiText(string text)
    {
        psiText.text = "PsiDegrees= "+text;
    }
}
