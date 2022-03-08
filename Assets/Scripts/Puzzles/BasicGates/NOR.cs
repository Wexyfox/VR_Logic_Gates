using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOR : MonoBehaviour
{
    private int stateChangeTime = 2;
    [SerializeField] GameObject testButton;
    [SerializeField] GameObject inputAButton;
    [SerializeField] GameObject inputBButton;
    [SerializeField] GameObject roomColorChanger;

    [SerializeField] GameObject inputBoxA;
    [SerializeField] GameObject inputBoxB;
    [SerializeField] GameObject outputBoxA;
    private bool puzzlePassed = false;
    private bool checkBool;

    private int stateCheck = 0;

    public void PuzzleCheck()
    {
        Invoke("StateSet1", stateChangeTime);
    }

    private void StateSet1()
    {
        inputBoxA.GetComponent<InputPower>().PowerOn();
        inputBoxB.GetComponent<InputPower>().PowerOn();
        Invoke("CheckSet1", stateChangeTime);
    }

    private void CheckSet1()
    {
        CheckOutputPower();
        if (!checkBool)
        {
            stateCheck += 1;
        }
        StateSet2();
    }

    private void StateSet2()
    {
        inputBoxA.GetComponent<InputPower>().PowerOff();
        inputBoxB.GetComponent<InputPower>().PowerOn();
        Invoke("CheckSet2", stateChangeTime);
    }

    private void CheckSet2()
    {
        CheckOutputPower();
        if (!checkBool)
        {
            stateCheck += 1;
        }
        StateSet3();
    }

    private void StateSet3()
    {
        inputBoxA.GetComponent<InputPower>().PowerOn();
        inputBoxB.GetComponent<InputPower>().PowerOff();
        Invoke("CheckSet3", stateChangeTime);
    }

    private void CheckSet3()
    {
        CheckOutputPower();
        if (!checkBool)
        {
            stateCheck += 1;
        }
        StateSet4();
    }

    private void StateSet4()
    {
        inputBoxA.GetComponent<InputPower>().PowerOff();
        inputBoxB.GetComponent<InputPower>().PowerOff();
        Invoke("CheckSet4", stateChangeTime);
    }

    private void CheckSet4()
    {
        CheckOutputPower();
        if (checkBool)
        {
            stateCheck += 1;
        }
        NANDPowerCheck();
    }

    private void NANDPowerCheck()
    {
        if (stateCheck == 4)
        {
            stateCheck = 0;
            puzzlePassed = true;
            roomColorChanger.GetComponent<RoomColorChange>().roomGreen();
        }
        else
        {
            stateCheck = 0;
            puzzlePassed = false;
            roomColorChanger.GetComponent<RoomColorChange>().roomRed();
        }
        TestButtonEnable();
    }

    public bool CheckPuzzlePassed()
    {
        return puzzlePassed;
    }

    private void CheckOutputPower()
    {
        checkBool = outputBoxA.GetComponent<OutputPower>().CheckPowered();
    }

    public void TestButtonDisable()
    {
        testButton.GetComponent<BoxCollider>().enabled = false;
        inputAButton.GetComponent<BoxCollider>().enabled = false;
        inputBButton.GetComponent<BoxCollider>().enabled = false;
    }

    private void TestButtonEnable()
    {
        testButton.GetComponent<BoxCollider>().enabled = true;
        inputAButton.GetComponent<BoxCollider>().enabled = true;
        inputBButton.GetComponent<BoxCollider>().enabled = true;
    }
}