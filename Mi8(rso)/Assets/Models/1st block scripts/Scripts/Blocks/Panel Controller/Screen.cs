using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour {

    [SerializeField] private GameObject listenModeTextObj;
    [SerializeField] private GameObject radioModeTextObj;

    private TextMesh listenModeText;
    private TextMesh radioModeText;

    private string listenText;
    private string radioText;

    private void Start () {
        listenModeText = listenModeTextObj.GetComponent<TextMesh>();
        radioModeText = radioModeTextObj.GetComponent<TextMesh>();
    }
	
	
	private void Update () {
        listenModeText.text = listenText;
        radioModeText.text = radioText;

    }

    public void SetListeModeText(string text)
    {
        listenText = text;
    }

    public void SetRadioModeText(string text)
    {
        radioText = text;
    }
}
