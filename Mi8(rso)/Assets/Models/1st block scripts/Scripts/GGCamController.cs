using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGCamController : MonoBehaviour {

    private float sensityHoriz = 9f;
    private float sensityVert = 9f;

    private float camZoomValue = 15f;
    [SerializeField] private GameObject cameraObj;

    private Camera playerCamera;
    private float cameraZoomValue;
  	
	private void Start () {
        playerCamera = cameraObj.GetComponent<Camera>();
        cameraZoomValue = playerCamera.fieldOfView;

    }
	
	
	void Update () {

        float delta =Input.GetAxis("Mouse X") * sensityHoriz;
        float rotationY = transform.localEulerAngles.y + delta;
        float delta1 = Input.GetAxis("Mouse Y") * sensityHoriz;
        float rotationX = transform.localEulerAngles.x - delta1;
        if (rotationX >= 180) rotationX = rotationX - 360;
            rotationX = Mathf.Clamp(rotationX, -60.0f, 60.0f);
        transform.localEulerAngles = new Vector3(rotationX, rotationY,0);
        CameraZoom();
    }

    private void CameraZoom()
    {
        if (Input.GetKey(KeyCode.LeftControl)  )
        {
               if(Input.mouseScrollDelta.y!=0)
            {
                camZoomValue -= Input.mouseScrollDelta.y;
            }
            playerCamera.fieldOfView =Mathf.Clamp(camZoomValue,1,80);
            sensityHoriz = 1;
            sensityVert = 1;
        }
        else
        {
            playerCamera.fieldOfView = cameraZoomValue;
            sensityHoriz = 9f;
            sensityVert = 9f;
        }
    }
}
