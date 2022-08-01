using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GameControl  : MonoBehaviour
{
    public UnityEngine.UI.Text firstNumber, secondNumber, transactionMark, status, result;
    public UnityEngine.UI.InputField resultInput;
    int  transMark;

    double firstNum, secondNum, transResult;

    void Start()
    {
        NewQuestion();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResultControl()
    {
        if (double.Parse(status.text) == transResult ){
            result.text = "Correct!";
        }else
        {
            result.text = "Wrong!";
        }


    }
    public void NewQuestion()
    {
        result.text = ""; 
        resultInput.text = "";

        firstNum =Random.Range(1, 100);
        secondNum =Random.Range(1, 100);
        transMark =Random.Range(1, 5);
        switch (transMark)
        {
            case 1:
                transactionMark.text = "+";
                transResult = firstNum + secondNum;
                break;
            case 2:
                transactionMark.text = "-";
                transResult = firstNum - secondNum;
                break;
            case 3:
                transactionMark.text = "*";
                transResult = firstNum * secondNum;
                break;
            case 4:
                firstNum = firstNum * secondNum;
                transactionMark.text = "/";
                transResult = firstNum / secondNum;
                
                break;
        }
        firstNumber.text = firstNum + "";
        secondNumber.text = secondNum + "";
    }
}
