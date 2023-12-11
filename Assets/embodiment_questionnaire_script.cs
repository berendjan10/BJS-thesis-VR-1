using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class embodiment_questionnaire_script : MonoBehaviour
{
    public List<Toggle> answerToggles; // assign toggles in Unity editor
    public Button doneButton; // assign button in Unity editor

    void Start()
    {
        doneButton.onClick.AddListener(ReadSurveyAnswers);
    }

    void ReadSurveyAnswers()
    {
        foreach (Toggle toggle in answerToggles)
        {
            if (toggle.isOn)
            {
                Debug.Log("Answer: " + toggle.name);
            }
        }
    }
}
