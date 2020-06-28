using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondControllPanel : MonoBehaviour
{
    private static SecondControllPanel panel = new SecondControllPanel();
    private SecondControllPanel()
    { }

    private ListenScrollBtnSecond listenScrollBtn;
    private RadioScrollBtnSecond radioScrollBtn;
    private SPUScrollBtn spuScrollBtn;

    [SerializeField] private GameObject radioScrollBtnObj;
    [SerializeField] private GameObject listenScrollBtnObj;
    [SerializeField] private GameObject spuScrollBtnObj;

    private IListenMode listenMode;
    private IRadioMode radioMode;
    private float spuValue;
    private void Start()
    {
        panel = GetComponent<SecondControllPanel>();

        radioScrollBtn = radioScrollBtnObj.GetComponent<RadioScrollBtnSecond>();
        listenScrollBtn = listenScrollBtnObj.GetComponent<ListenScrollBtnSecond>();
        spuScrollBtn = spuScrollBtnObj.GetComponent<SPUScrollBtn>();

        SetListenMode(new DisableMode());
        SetRadioMode(new UKV1mode());
        SetSpuVale(0);
    }

    
    void Update()
    {
        
    }
    public static SecondControllPanel Do()
    {
        return panel;
    }
    public void SetListenMode(IListenMode listen)
    {
        listenMode = listen;
    }
    public IListenMode GetListenMode()
    {
        return listenMode;
    }

    public void SetRadioMode(IRadioMode radio)
    {
        radioMode = radio;
    }
    public IRadioMode GetRadioMode()
    {
        return radioMode;
    }
    public void SetSpuVale(float value)
    {
        spuValue = value;
    }
    public float GetSpuValue()
    {
        return spuValue;
    }
}
