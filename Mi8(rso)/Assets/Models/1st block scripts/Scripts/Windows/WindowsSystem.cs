using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowsSystem : MonoBehaviour,IMovementObserver {
    private static WindowsSystem winSystem;

    private bool isShowShortDescription = false;

    [SerializeField] private Text velocityText;
    [SerializeField] private Text heightText;
    [SerializeField] private Text psiText;
    private SimulateHeliMovement heliMovement;

    [SerializeField] private GameObject descriptionObj;
    private DescriptionWindow descriptionWindow;

    [SerializeField] private GameObject helpObj;
    private HelpWindow helpWindow;

    [SerializeField] private GameObject helloObj;
    private HelloWindow helloWindow;

    [SerializeField] private GameObject chooseModeObj;
    private ChooseModeWindow chooseModeWindow;

    [SerializeField] private GameObject parametrsWindowObj;
    private ParametrsWindow parametrsWindow;

    private WindowsSystem()
    {
    }

	private void Start () {
        winSystem = GetComponent<WindowsSystem>();

        descriptionWindow = new DescriptionWindow(descriptionObj);
        helpWindow = new HelpWindow(helpObj);
        helloWindow = new HelloWindow(helloObj);
        chooseModeWindow = new ChooseModeWindow(chooseModeObj);
        parametrsWindow = new ParametrsWindow(parametrsWindowObj,velocityText,heightText,psiText);

        heliMovement = GetComponent<SimulateHeliMovement>();
        heliMovement.RegisterObserver(this);

        DisableDescriptionWindow();
        DisableHelpWindow();
        DisableChooseModeWindow();
        EnableHelloWindow();
        DisableParametrsWindow();

    }	
	void Update () {
		if(Input.GetKeyDown(KeyCode.F11))
        {
            if (helpWindow.windowObj.activeSelf)
            {
                DisableHelpWindow();
            }
            else if (helpWindow.windowObj.activeSelf == false)
            {
                EnableHelpWindow();
               
            }
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            if (parametrsWindow.windowObj.activeSelf)
            {
                DisableParametrsWindow();
            }
            else if (parametrsWindow.windowObj.activeSelf == false)
            {
                EnableParametrsWindow();

            }
        }
    }

    public static  WindowsSystem Do()
    {
        return winSystem;
    }

    public void SetDescription(string text)
    {
        descriptionWindow.SetDescriptionText(text);
    }
    public void EnableDescriptionWindow()
    {
        descriptionWindow.On();
    }
    public void DisableDescriptionWindow()
    {
        descriptionWindow.Off();
    }
    public void EnableHelpWindow()
    {
        helpWindow.On();
        FreezeMouseLook(true);
    }
    public void DisableHelpWindow()
    {
        helpWindow.Off();
        FreezeMouseLook(false);
    }
    public void EnableHelloWindow()
    {
        helloWindow.On();       
        FreezeMouseLook(true);
    }
    public void DisableHelloWindow()
    {
        helloWindow.Off();
        FreezeMouseLook(false);
    }
    public void EnableParametrsWindow()
    {
       parametrsWindow.On();
         
    }
    public void DisableParametrsWindow()
    {
        parametrsWindow.Off();
    }

    public void FreezeMouseLook(bool freeze)
    {
        GameObject camera = GameObject.FindGameObjectWithTag("Player");
        if (freeze == true)
        {
            camera.GetComponent<GGCamController>().enabled = false;
        }
        else if (freeze == false)
        {
            camera.GetComponent<GGCamController>().enabled = true;
        }
    }
   
    public void ShowShortDecription(string text)
    {
        StartCoroutine(ShortDescription(text));
    }
    public bool GetShortShowDescriptionFlag()
    {
        return isShowShortDescription;
    }

    private IEnumerator ShortDescription(string text)
    {
        isShowShortDescription = true;
        EnableDescriptionWindow();
        SetDescription(text);
        yield return new WaitForSeconds(3f);
        isShowShortDescription = false;
        DisableDescriptionWindow();
    }

    public void EnableChooseModeWindow()
    {
       chooseModeWindow.On();
        FreezeMouseLook(true);
    }
    public void DisableChooseModeWindow()
    {
        chooseModeWindow.Off();
        FreezeMouseLook(false);
    }
    public void ChooseModeTheori()
    {
        chooseModeWindow.LoadTheori();
    }
    public void ChooseModeTest()
    {
        chooseModeWindow.LoadTest();
    }

    public void ChangeObserver(float H, float V, float psi)
    {
        parametrsWindow.SetHeightText(H.ToString());
        parametrsWindow.SetVelocityText(V.ToString());
        parametrsWindow.SetPsiText(psi.ToString());
    }
}
