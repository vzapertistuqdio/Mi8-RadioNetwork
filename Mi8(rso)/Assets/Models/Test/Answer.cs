using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour {

    [SerializeField] private GameObject subjObj;
    private Toggle answerToggle;
    private bool isOnFirstTime = false;


    private void Start () {
        answerToggle = GetComponent<Toggle>();
	}
		
	private void Update () {
		if(answerToggle.isOn && isOnFirstTime==false)
        {
            subjObj.GetComponent<Question>().DisableAllAnswer();
            answerToggle.isOn = true;
            isOnFirstTime = true;
        }
        if(answerToggle.isOn==false)
        {
            isOnFirstTime = false;
        }
               
	}
}
