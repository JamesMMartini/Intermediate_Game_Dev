using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    public enum Stages { StageZero, StageOne, StageTwo, StageThree };
    public Stages myStage = Stages.StageZero;

    public TMP_Text myText;
    string defaultText = "default text";

    public string textOne;
    public string textTwo;

    int textNumber;
    int count = 0;

    private void Awake()
    {
        myText = GetComponent<TMP_Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        myText.text = defaultText;
    }

    void EnumTextChanger()
    {
        if (myStage < Stages.StageThree)
        {
            myText.text = myStage.ToString();
            myStage++;
        }
        else
        {
            myText.text = myStage.ToString();
            myStage = Stages.StageZero;
        }
    }

    void TextInputChanger()
    {
        if (textNumber == 0)
        {
            myText.text = textOne;
            textNumber = 1;
        }
        else
        {
            myText.text = textTwo;
            textNumber = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnumTextChanger();
        }
    }
}
