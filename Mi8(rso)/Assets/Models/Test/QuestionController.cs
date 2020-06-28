using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionController : MonoBehaviour {

    [SerializeField] private GameObject[] questions;

    [SerializeField] private GameObject canvas;
    [SerializeField] private Text questionCountText;
    [SerializeField] private Text markText;

    [SerializeField] private GameObject reloadBtn;
    [SerializeField] private GameObject exitBtn;
    [SerializeField] private GameObject closeBtn;
    [SerializeField] private GameObject startBtn;

    private int trueAnswers = 0;
    private int falseAnswers = 0;

    private int currentQuestion = 1;


    private void Start () {
        reloadBtn.SetActive(false);
        exitBtn.SetActive(false);
	}
	

	private void Update () {
        questionCountText.text = "Вопрос " + currentQuestion + "/" + questions.Length;
    }

    public void OnStartBtnClick()
    {
        for(int i=0;i<questions.Length;i++)
        {
            Instantiate(questions[i], canvas.transform);
        }
        startBtn.SetActive(false);
    }
    public void IncreaseFalseAnswer()
    {
        falseAnswers = falseAnswers + 1;
    }
    public void IncreaseTrueAnswer()
    {
        trueAnswers = trueAnswers + 1;
    }
    public int GetQuestionsCount()
    {
        return questions.Length;
    }
    public int GetCurrentQuestion()
    {
        return currentQuestion;
    }
    public void CurrentQuestionIncrease()
    {
        currentQuestion = currentQuestion + 1;
    }
    public void TakeMark()
    {
        markText.text = "Ваша оценка: " + CalculateMark() + "\n" + "Кол-во правильных ответов: " + trueAnswers + "\n" + "Кол-во неправильных ответов: " + falseAnswers;
        reloadBtn.SetActive(true);
        exitBtn.SetActive(true);
    }
    public int CalculateMark()
    {
        int result = 0;
        float answerCost = 10f / questions.Length;
        float floatMark = answerCost * trueAnswers;
        float part = floatMark % 1;
        if (part >= 0.5)
        {
            result = (int)floatMark + 1;
        }
        else result = (int)floatMark;
        return result;
    }
    public void OnExitBtnClick()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void OnCloseBtnClick()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void OnReloadBtnClick()
    {
        SceneManager.LoadScene("TestScene");
    }

  

}
