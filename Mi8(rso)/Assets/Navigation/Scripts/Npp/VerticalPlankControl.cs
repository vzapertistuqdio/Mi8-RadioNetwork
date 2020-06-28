using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlankControl : MonoBehaviour, IMovementObserver
{
    private SimulateHeliMovement heliMovement;
    private float H;
    private float V;
    private float psi;

    private Vector3 moveVector;
    private Vector3 prevousVector;
    private Vector3 lastPosition;

    private float changeSpeed = 0.425f;

    private Transform plankTransform;

   private enum Turning { Left,Right}


    public void ChangeObserver(float H, float V, float psi)
    {
        this.H = H;
        this.psi = psi;
        this.V = V;
    }

    void Start () {
        heliMovement = GameObject.FindGameObjectWithTag("Controller").GetComponent<SimulateHeliMovement>();
        heliMovement.RegisterObserver(this);
        plankTransform = GetComponent<Transform>();
        prevousVector = moveVector;
        lastPosition= new Vector3(0, 0, 0);
    }
    void Update()
    {
        UsePlank(moveVector);
       

    }
    float prevousDegreesValue = 0;

    private void UsePlank(Vector3 moveVector)
    {
        float turnDegrees = psi / Mathf.Deg2Rad;

        const float  MAX_X_VALUE= 0.40f;
        if (turnDegrees < 360 && turnDegrees >= 340)
        {
            float delta = 360 - turnDegrees;
            float posZ = delta * 0.0225f;
            if (prevousDegreesValue < turnDegrees)
            {
                plankTransform.localPosition = new Vector3(plankTransform.localPosition.x, plankTransform.localPosition.y, Mathf.Clamp(-posZ, -MAX_X_VALUE, 0) );
             
            }
            if (prevousDegreesValue > turnDegrees)
            {
                
                 plankTransform.localPosition = new Vector3(plankTransform.localPosition.x, plankTransform.localPosition.y, Mathf.Clamp(-posZ, -MAX_X_VALUE, 0) );
              
            }
            prevousDegreesValue = turnDegrees;
        }

        if (turnDegrees <= 20 && turnDegrees >= 0)
        {
         
            float delta = turnDegrees;
            float posZ = delta * 0.0225f;
            if (prevousDegreesValue < turnDegrees)
            {
                 plankTransform.localPosition = new Vector3(plankTransform.localPosition.x, plankTransform.localPosition.y, Mathf.Clamp(+posZ, 0, MAX_X_VALUE) );
               
            }
            if (prevousDegreesValue > turnDegrees)
            {
                 plankTransform.localPosition =new Vector3(plankTransform.localPosition.x, plankTransform.localPosition.y, Mathf.Clamp(posZ, 0, MAX_X_VALUE) );
             
            }
           prevousDegreesValue = turnDegrees;
        }


    
    }

 

   

}
