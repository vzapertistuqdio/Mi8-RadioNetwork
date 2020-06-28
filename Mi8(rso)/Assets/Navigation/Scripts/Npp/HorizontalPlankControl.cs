using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlankControl : MonoBehaviour, IMovementObserver
{
    private SimulateHeliMovement heliMovement;
    private float H;
    private float V;
    private float psi;

    private  float prevousH=200;

    private float changeSpeed = 0.045f;

    private Transform plankTransform;


    public void ChangeObserver(float H, float V, float psi)
    {
        this.H = H;
        this.psi = psi;
        this.V = V;
    }

    void Start()
    {
        heliMovement = GameObject.FindGameObjectWithTag("Controller").GetComponent<SimulateHeliMovement>();
        heliMovement.RegisterObserver(this);
        plankTransform = GetComponent<Transform>();
    }

    void Update()
    {
        UsePlank(H);  
    }
    private void UsePlank(float dH)
    {
        if (H > prevousH) 
        {
            plankTransform.localPosition = new Vector3(Mathf.Clamp(plankTransform.localPosition.x, -0.3f, 0.3f) - changeSpeed * Time.deltaTime, plankTransform.localPosition.y, plankTransform.localPosition.z);
            prevousH = dH;
        }
        if (H < prevousH)
        {
            plankTransform.localPosition = new Vector3( Mathf.Clamp(plankTransform.localPosition.x, -0.3f, 0.3f) + changeSpeed * Time.deltaTime, plankTransform.localPosition.y, plankTransform.localPosition.z);
            prevousH = dH;
        }
    }
}
