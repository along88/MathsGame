using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Quiz : MonoBehaviour
{
    public Question[] questions;
    private Text questionText;
    private Text[] textAnswers;
    public int questionID;
    public int maxQuestions;
    private GameObject canvas;
    private int ID;

    void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvas");

    }

    void Start()
    {
        Question currentQuestion = questions[questionID];
        Transform question = transform.FindChild("questionText");
        questionText = question.GetComponent<Text>();
        textAnswers = new Text[currentQuestion.answers.Length];
        maxQuestions = questions.Length - 1;
        for (int i = 0; i < currentQuestion.answers.Length; i++)
        {
            textAnswers[i] = question.GetChild(i).GetChild(0).GetComponent<Text>();
        }
        currentQuestion =
    }
	
}
[System.Serializable] //makes it available in inspector
public class Question
{
    
    public string text;
    public string[] answers;
    public int answerID;

   
}
