using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour {

    private Camera camera;

	private void Start () {
        camera = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	
	
	private void Update () {
        Vector3 point = new Vector3(camera.pixelWidth/2,camera.pixelHeight/2,0);
        Ray ray = camera.ScreenPointToRay(point);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "Button")
            {
                IPushContinous btn = hit.transform.gameObject.GetComponent<IPushContinous>();
                if (btn != null)
                {
                    if (Input.GetMouseButton(0))
                    {
                        btn.PushContin();
                    }
                }
                else
                {
                  
                    IControllButton controllBtn = hit.transform.gameObject.GetComponent<IControllButton>();

                    if (WindowsSystem.Do().GetShortShowDescriptionFlag() == false)
                    {
                        WindowsSystem.Do().EnableDescriptionWindow();
                        WindowsSystem.Do().SetDescription(controllBtn.GetDescription());
                    }
                    if (Input.GetMouseButtonDown(0))
                    {
                        controllBtn.Push();
                    }
                }             
            }
            else
            {
                WindowsSystem.Do().DisableDescriptionWindow();
                WindowsSystem.Do().SetDescription(" ");
            }
            IDescripted description = hit.transform.gameObject.GetComponent<IDescripted>();
            if (description != null)
            {

                if (WindowsSystem.Do().GetShortShowDescriptionFlag() == false)
                {
                    WindowsSystem.Do().EnableDescriptionWindow();
                    WindowsSystem.Do().SetDescription(description.GetDescription());
                }
            }
        }


    }
    private void OnGUI()
    {
        int size = 12;
        float posX = camera.pixelWidth / 2 - size / 4;
        float posY = camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX,posY,size,size),"*");
    }
}
