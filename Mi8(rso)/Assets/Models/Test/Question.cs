using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Question : MonoBehaviour {

    [SerializeField] private Toggle[] allAnswers;
    [SerializeField] private Toggle trueAnswer;
    [SerializeField] private GameObject trueAnswerText;
    [SerializeField] private GameObject falseAnswerText;

    private bool canMoveDown;

    [SerializeField] private GameObject answerBtn;
    
    private GameObject controllerObj;
    private QuestionController controller;

    private void Start()
    {
        trueAnswerText.SetActive(false);
        falseAnswerText.SetActive(false);
        canMoveDown = false;
        controllerObj = GameObject.FindGameObjectWithTag("Controller");
        controller = controllerObj.GetComponent<QuestionController>();
    }
    private void Update()
    {
        if(canMoveDown)
        {
            transform.Translate(0,-10f,0);
        }
    }

    public void OnAnswerBtnClick()
    {
        answerBtn.SetActive(false);
        if (trueAnswer.isOn)
        {
            trueAnswerText.SetActive(true);
            controller.IncreaseTrueAnswer();
        }
        else
        {
            falseAnswerText.SetActive(true);
            controller.IncreaseFalseAnswer();
        }
        if (controller.GetQuestionsCount() > controller.GetCurrentQuestion())
        {
            StartCoroutine(CurrentQuestionCountIncrease(2));
        }
        else
        {
            StartCoroutine(TakeMark(2));
            
        }
        StartCoroutine(DestroyQuestion());
    }

    public void DisableAllAnswer()
    {
        foreach (Toggle answer in allAnswers)
        {
            if (answer.isOn)
            {
                answer.isOn = false;
            }
        }
    }
    private IEnumerator DestroyQuestion()
    {
        yield return new WaitForSeconds(2f);
        canMoveDown = true;
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }
    private IEnumerator TakeMark(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        controller.TakeMark();
    }
    private IEnumerator CurrentQuestionCountIncrease(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        controller.CurrentQuestionIncrease();
    }

}
