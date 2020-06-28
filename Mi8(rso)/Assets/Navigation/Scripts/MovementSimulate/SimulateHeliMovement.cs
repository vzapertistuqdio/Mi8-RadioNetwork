using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulateHeliMovement : MonoBehaviour,IMovementSubject {


    public float Psi { get;private set; }
    public float Velocity { get; private set; }
    public float Height { get; private set; }

    private List<IMovementObserver> observers;

    private float Apsi, Fpsi;
    private float deltaH=0.1f;
    private float dPsi;

    private void Start () {
        observers = new List<IMovementObserver>();

        Psi = Mathf.Deg2Rad * 0;
        Apsi = 0.8f;
        Fpsi = 0.35f;
        Velocity = 150f;
        dPsi = 0.1f;
        Height = 200;
        deltaH = 0.1f;
    }
	

	private void Update () {
        Psi = CalculateDegrees();
       Height=CalculateNewHeight(deltaH);
        UpdateObservers();
    }


    private float CalculateDegrees()
    {
        dPsi = Apsi * Mathf.Cos(Fpsi * Time.fixedTime);
        Psi += dPsi * Time.deltaTime;
        if (Psi > 2 * Mathf.PI) Psi = Psi - 2 * Mathf.PI;
        if (Psi < 0) Psi = Psi + 2 * Mathf.PI;
        return Psi;
    }

    private float CalculateNewHeight(float deltaH)
    {
        Height = Height + Random.Range(-3,4)*deltaH;
        return Height;
    }

    private float CalculateDeltaHeight()
    {
        if (Height > 280) deltaH = -0.1f;
        if (Height < 165) deltaH = 0.1f;
        return deltaH;
    }

    private Vector3 GetMoveVector(float x, float z)
    {
        return new Vector3(x, transform.position.y, z);
    }

    public void RegisterObserver(IMovementObserver obs)
    {
        observers.Add(obs);
    }

    public void RemoveObserver(IMovementObserver obs)
    {
        observers.Remove(obs);
    }

    public void UpdateObservers()
    {
        for (int i = 0; i < observers.Count; i++)
        {
            IMovementObserver observer = observers[i];
            observer.ChangeObserver(Height, Velocity, Psi);
        }
    }
}
