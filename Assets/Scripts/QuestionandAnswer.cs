using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class QuestionandAnswer : MonoBehaviour
{
    [SerializeField]
    public string Question;
    public GameObject Answer;
    public int CorrectAnswer;
}
