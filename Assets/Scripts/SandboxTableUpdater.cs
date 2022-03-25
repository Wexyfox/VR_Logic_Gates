using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandboxTableUpdater : MonoBehaviour
{
    private int stateChangeTime = 2;
    [SerializeField] GameObject roomController;

    [SerializeField] GameObject inputBoxA;
    [SerializeField] GameObject inputBoxB;
    [SerializeField] GameObject inputBoxC;

    private InputPower inputAPower;
    private InputPower inputBPower;
    private InputPower inputCPower;

    [SerializeField] GameObject outputBoxA;
    [SerializeField] GameObject outputBoxB;
    [SerializeField] GameObject outputBoxC;

    private OutputPower outputAPower;
    private OutputPower outputBPower;
    private OutputPower outputCPower;

    private bool tempA;
    private bool tempB;
    private bool tempC;

    [SerializeField] GameObject row1A;
    [SerializeField] GameObject row1B;
    [SerializeField] GameObject row1C;

    [SerializeField] GameObject row2A;
    [SerializeField] GameObject row2B;
    [SerializeField] GameObject row2C;

    [SerializeField] GameObject row3A;
    [SerializeField] GameObject row3B;
    [SerializeField] GameObject row3C;

    [SerializeField] GameObject row4A;
    [SerializeField] GameObject row4B;
    [SerializeField] GameObject row4C;

    [SerializeField] GameObject row5A;
    [SerializeField] GameObject row5B;
    [SerializeField] GameObject row5C;

    [SerializeField] GameObject row6A;
    [SerializeField] GameObject row6B;
    [SerializeField] GameObject row6C;

    [SerializeField] GameObject row7A;
    [SerializeField] GameObject row7B;
    [SerializeField] GameObject row7C;

    [SerializeField] GameObject row8A;
    [SerializeField] GameObject row8B;
    [SerializeField] GameObject row8C;

    private void Start()
    {
        inputAPower = inputBoxA.GetComponent<InputPower>();
        inputBPower = inputBoxB.GetComponent<InputPower>();
        inputCPower = inputBoxC.GetComponent<InputPower>();

        outputAPower = outputBoxA.GetComponent<OutputPower>();
        outputBPower = outputBoxB.GetComponent<OutputPower>();
        outputCPower = outputBoxC.GetComponent<OutputPower>();
    }

    private void OutputCheck()
    {
        tempA = outputAPower.CheckPowered();
        tempB = outputBPower.CheckPowered();
        tempC = outputCPower.CheckPowered();
    }

    public void SandboxTableUpdate()
    {
        ResetCells();
        Invoke("StateSet1", stateChangeTime);
    }

    private void StateSet1()
    {
        inputAPower.PowerOn();
        inputBPower.PowerOn();
        inputCPower.PowerOn();
        UpdateRow(1);
        Invoke("StateSet2", stateChangeTime);
    }

    private void StateSet2()
    {
        inputAPower.PowerOn();
        inputBPower.PowerOn();
        inputCPower.PowerOff();
        UpdateRow(2);
        Invoke("StateSet3", stateChangeTime);
    }

    private void StateSet3()
    {
        inputAPower.PowerOff();
        inputBPower.PowerOn();
        inputCPower.PowerOn();
        UpdateRow(3);
        Invoke("StateSet4", stateChangeTime);
    }

    private void StateSet4()
    {
        inputAPower.PowerOn();
        inputBPower.PowerOff();
        inputCPower.PowerOn();
        UpdateRow(4);
        Invoke("StateSet5", stateChangeTime);
    }

    private void StateSet5()
    {
        inputAPower.PowerOn();
        inputBPower.PowerOff();
        inputCPower.PowerOff();
        UpdateRow(5);
        Invoke("StateSet6", stateChangeTime);
    }

    private void StateSet6()
    {
        inputAPower.PowerOff();
        inputBPower.PowerOn();
        inputCPower.PowerOff();
        UpdateRow(6);
        Invoke("StateSet7", stateChangeTime);
    }

    private void StateSet7()
    {
        inputAPower.PowerOff();
        inputBPower.PowerOff();
        inputCPower.PowerOn();
        UpdateRow(7);
        Invoke("StateSet8", stateChangeTime);
    }

    private void StateSet8()
    {
        inputAPower.PowerOff();
        inputBPower.PowerOff();
        inputCPower.PowerOff();
        UpdateRow(8);
        roomController.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
    }

    private void UpdateRow(int rowNumber)
    {
        OutputCheck();
        if (rowNumber == 1)
        {
            if (tempA)
            {
                row1A.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row1A.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempB)
            {
                row1B.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row1B.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempC)
            {
                row1C.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row1C.GetComponent<SandboxCellChange>().NegativeCell();
            }
        }
        else if (rowNumber == 2)
        {
            if (tempA)
            {
                row2A.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row2A.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempB)
            {
                row2B.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row2B.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempC)
            {
                row2C.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row2C.GetComponent<SandboxCellChange>().NegativeCell();
            }
        }
        else if (rowNumber == 3)
        {
            if (tempA)
            {
                row3A.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row3A.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempB)
            {
                row3B.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row3B.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempC)
            {
                row3C.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row3C.GetComponent<SandboxCellChange>().NegativeCell();
            }
        }
        else if (rowNumber == 4)
        {
            if (tempA)
            {
                row4A.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row4A.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempB)
            {
                row4B.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row4B.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempC)
            {
                row4C.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row4C.GetComponent<SandboxCellChange>().NegativeCell();
            }
        }
        else if (rowNumber == 5)
        {
            if (tempA)
            {
                row5A.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row5A.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempB)
            {
                row5B.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row5B.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempC)
            {
                row5C.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row5C.GetComponent<SandboxCellChange>().NegativeCell();
            }
        }
        else if (rowNumber == 6)
        {
            if (tempA)
            {
                row6A.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row6A.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempB)
            {
                row6B.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row6B.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempC)
            {
                row6C.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row6C.GetComponent<SandboxCellChange>().NegativeCell();
            }
        }
        else if (rowNumber == 7)
        {
            if (tempA)
            {
                row7A.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row7A.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempB)
            {
                row7B.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row7B.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempC)
            {
                row7C.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row7C.GetComponent<SandboxCellChange>().NegativeCell();
            }
        }
        else if (rowNumber == 8)
        {
            if (tempA)
            {
                row8A.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row8A.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempB)
            {
                row8B.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row8B.GetComponent<SandboxCellChange>().NegativeCell();
            }

            if (tempC)
            {
                row8C.GetComponent<SandboxCellChange>().PositiveCell();
            }
            else
            {
                row8C.GetComponent<SandboxCellChange>().NegativeCell();
            }
        }
    }

    private void ResetCells()
    {
        row1A.GetComponent<SandboxCellChange>().EmptyCell();
        row1B.GetComponent<SandboxCellChange>().EmptyCell();
        row1C.GetComponent<SandboxCellChange>().EmptyCell();

        row2A.GetComponent<SandboxCellChange>().EmptyCell();
        row2B.GetComponent<SandboxCellChange>().EmptyCell();
        row2C.GetComponent<SandboxCellChange>().EmptyCell();

        row3A.GetComponent<SandboxCellChange>().EmptyCell();
        row3B.GetComponent<SandboxCellChange>().EmptyCell();
        row3C.GetComponent<SandboxCellChange>().EmptyCell();

        row4A.GetComponent<SandboxCellChange>().EmptyCell();
        row4B.GetComponent<SandboxCellChange>().EmptyCell();
        row4C.GetComponent<SandboxCellChange>().EmptyCell();

        row5A.GetComponent<SandboxCellChange>().EmptyCell();
        row5B.GetComponent<SandboxCellChange>().EmptyCell();
        row5C.GetComponent<SandboxCellChange>().EmptyCell();

        row6A.GetComponent<SandboxCellChange>().EmptyCell();
        row6B.GetComponent<SandboxCellChange>().EmptyCell();
        row6C.GetComponent<SandboxCellChange>().EmptyCell();

        row7A.GetComponent<SandboxCellChange>().EmptyCell();
        row7B.GetComponent<SandboxCellChange>().EmptyCell();
        row7C.GetComponent<SandboxCellChange>().EmptyCell();

        row8A.GetComponent<SandboxCellChange>().EmptyCell();
        row8B.GetComponent<SandboxCellChange>().EmptyCell();
        row8C.GetComponent<SandboxCellChange>().EmptyCell();
    }
}
