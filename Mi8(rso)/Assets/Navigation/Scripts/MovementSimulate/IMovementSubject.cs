using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementSubject  {
    void RegisterObserver(IMovementObserver obs);
    void RemoveObserver(IMovementObserver obs);
    void UpdateObservers();

}
