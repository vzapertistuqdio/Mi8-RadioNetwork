using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiostationControllPanel : MonoBehaviour {


    private UKV1btn ukv1btn;
    private UKV2btn ukv2btn;
    private KVbtn kvbtn;

    [SerializeField] private GameObject ukv1BtnObj;
    [SerializeField] private GameObject ukv2BtnObj;
    [SerializeField] private GameObject kvBtnObj;


    private RadioScrollBtn radioScrollbtn;
    private ListenScrollbtn listenScrollbtn;
    private EnterScrollBtn enterScrollbtn;

    [SerializeField] private GameObject radioScrollBtnObj;
    [SerializeField] private GameObject listenScrollBtnObj;
    [SerializeField] private GameObject enterScrollBtnObj;

    private Screen screen;

    private IListenMode listenMode;
    private IRadioMode radioMode;
    private IEnterMode enterMode;
    private IRadiostation radiostationMode;

    

    private void Start () {
    
      
        screen = GetComponent<Screen>();
        SetRadiostation(new UKV1Radiostation());

        ukv1btn = ukv1BtnObj.GetComponent<UKV1btn>();
        ukv2btn = ukv2BtnObj.GetComponent<UKV2btn>();
        kvbtn = kvBtnObj.GetComponent<KVbtn>();

        radioScrollbtn = radioScrollBtnObj.GetComponent<RadioScrollBtn>();
        listenScrollbtn = listenScrollBtnObj.GetComponent<ListenScrollbtn>();
        enterScrollbtn = enterScrollBtnObj.GetComponent<EnterScrollBtn>();

        SetListenMode(new VSmode());
        SetRadioMode(new UKV1mode());
        SetEnterMode(new PRDUmode());
       
    }
	
	
	void Update () {
     
    }

    public  RadiostationControllPanel Do()
    {
        return GetComponent<RadiostationControllPanel>(); ;
    }

    public void SetRadiostation(IRadiostation radiostation)
    {
        radiostationMode = radiostation;
    }
    public IRadiostation GetRadiostation()
    {
       return radiostationMode;
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

    public void SetEnterMode(IEnterMode enter)
    {
        enterMode =enter;
    }
    public IEnterMode GetEnterMode()
    {
        return enterMode;
    }

    public void SetScreenListenMode(string text)
    {
        screen.SetListeModeText(text);
    }
    public void SetScreenRadioMode(string text)
    {
        screen.SetRadioModeText(text);
    }
}
