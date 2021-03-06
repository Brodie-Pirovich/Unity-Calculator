using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField]
    Text resultText;

    [SerializeField]
    Text NumberText;

    [SerializeField]
    Text Number2Text;

    [SerializeField]
    Text OperatorText;

    [SerializeField]
    RunLog logControl;

    [SerializeField]
    CubeManager cube;

    [SerializeField]
    GameObject gameManger;

    [SerializeField]
    int inputValue;
    int previousVal;
    int redoVal;
    int[] values = new int[2];
    string opperatorSymbol;
    int i = 0;
    int result;
    public bool b_undo = false;

    private void Update()
    {
        if(Input.GetKeyDown("z"))
        {
            Undo();
        }

        if (Input.GetKeyDown("x"))
        {
            Redo();
        }

        /*Debug.Log("value 1 is: " + values[0]);
        Debug.Log("value 2 is: " + values[1]);
        Debug.Log("Symbol is: " + opperatorSymbol);*/
        NumberText.text = opperatorSymbol;

        if (b_undo == true)
        {
            Undo();
            b_undo = false;
        }
    }

    public void InputButtonPressed(int val)
    {
        inputValue = val;
        if (i > 1)
        {
            i = 0;
        }

        if(values[i] != 0)
        {
            previousVal = values[i];
        }
        values[i] = inputValue;
        logControl.myText = inputValue.ToString();
        logControl.LogText();
        i++;

        resultText.text = val.ToString();
    }

    public void Undo()
    {
        if (i > 1)
        {
            i = 0;
        }
        else
        {
            i = 1;
        }

        redoVal = values[i];
        values[i] = previousVal;
        logControl.myText = values[i].ToString();
        logControl.LogText();
    }

    public void Redo()
    {
        if (i > 1)
        {
            i = 0;
        }
        else
        {
            i = 1;
        }
        values[i] = redoVal;
        logControl.myText = values[i].ToString();
        logControl.LogText();
    }

    public void OpperatorButtonPressed(string val)
    {
        opperatorSymbol = val;

        resultText.text = val.ToString();
    }

    public void Calculate()
    {
        switch(opperatorSymbol)
        {
            case "+":
                Add();
                break;
            case "-":
                Subtract();
                break;
            case "/":
                Divide();
                break;
            case "*":
                Multi();
                break;
            case "Pow":
                float numb1 = (float)values[0];
                float numb2 = (float)values[1];
                float pResult = Mathf.Pow(numb1, numb2);
                resultText.text = pResult.ToString();
                uint p = (uint)(float)pResult;
                cube.CreateCubes(1, p, 1);
                break;
            case "Sqrt":
                float numb = (float)values[0];
                float sResult = Mathf.Sqrt(numb);
                resultText.text = sResult.ToString();
                uint s = (uint)(float)sResult;
                cube.CreateCubes(1, s, 1);
                break;
        }

        this.GetComponent<Shoot>().enabled = true;
    }

    public void Add()
    {
        result = values[0] + values[1];
        resultText.text = result.ToString();
        logControl.myText = result.ToString();
        logControl.LogText();
        uint u = (uint)(int)result;
        cube.CreateCubes(1, u, 1);
    }

    public void Subtract()
    {
        result = values[0] - values[1];
        resultText.text = result.ToString();
        logControl.myText = result.ToString();
        logControl.LogText();
        uint z = (uint)(int)result;
        cube.CreateCubes(1, z, 1);
    }

    public void Divide()
    {
        result = values[0] / values[1];
        resultText.text = result.ToString();
        logControl.myText = result.ToString();
        logControl.LogText();
        uint x = (uint)(int)result;
        cube.CreateCubes(1, x, 1);
    }

    public void Multi()
    {
        result = values[0] * values[1];
        resultText.text = result.ToString();
        logControl.myText = result.ToString();
        logControl.LogText();
        uint v = (uint)(int)result;
        cube.CreateCubes(1, v, 1);
    }
}
