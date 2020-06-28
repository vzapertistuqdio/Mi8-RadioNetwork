using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RV : MonoBehaviour,IMovementObserver,IDescripted {

    private SimulateHeliMovement heliMovement;

    private string desription = "Высотомер РВ-15";

    private float height=220;

    private Transform arrowTransform;

    public void ChangeObserver(float H, float V, float psi)
    {
     height = H; 
    }

    public string GetDescription()
    {
        return desription;
    }

    private void Start () {
        heliMovement =GameObject.FindGameObjectWithTag("Controller").GetComponent<SimulateHeliMovement>();
        heliMovement.RegisterObserver(this);
        arrowTransform = transform.GetChild(0).GetComponent<Transform>();
    }
	
	
	private void Update () {

        if (height <= 10)
        {
            arrowTransform.rotation = Quaternion.Euler(0, 0, height*3.3f);
        }
        else  if (height > 10 && height<=20)
        {
            arrowTransform.rotation = Quaternion.Euler(0, 0, height*3.1f);
        }
        else if(height > 20 && height <= 30)
        {
            arrowTransform.rotation = Quaternion.Euler(0, 0, height * 3f);
        }
        else if (height > 30 && height <= 50)
        {
            arrowTransform.rotation = Quaternion.Euler(0, 0, height * 3f);
        }
        else if (height > 50 && height <= 100)
        {
            arrowTransform.rotation = Quaternion.Euler(0, 0, height * 1.8f);
        }
        else if (height > 100 && height <= 150)
        {
            arrowTransform.rotation = Quaternion.Euler(0, 0, height * 1.4f);
        }
        else if (height > 150 && height <= 215)
        {
            arrowTransform.rotation = Quaternion.Euler(0, 0, height * 1.2f);
        }
        else if (height > 215 && height <= 300)
        {
            arrowTransform.rotation = Quaternion.Euler(0, 0, height * 1.05f);
        }





    }
}
