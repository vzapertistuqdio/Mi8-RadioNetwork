using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabRotate : MonoBehaviour {

    private float deltaX;
    private float deltaY;
    private float sensity = 10f;
 

    private void Start()
    {
     
    }

    private void Update () {
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.y>Camera.main.pixelHeight/3)
            {
                deltaX = transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * sensity;
                deltaY = transform.localEulerAngles.y - Input.GetAxis("Mouse X") * sensity;
                if (deltaX > 90 && deltaX < 180)
                    deltaX = 90;
                if (deltaX <= 270 && deltaX > 90)
                {
                    deltaX = 270;
                }
                transform.localEulerAngles = new Vector3(deltaX, deltaY, 0);
            }
        }
    
    }
}
