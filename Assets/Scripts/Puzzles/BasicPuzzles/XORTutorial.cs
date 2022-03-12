using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XORTutorial : MonoBehaviour
{
    private int stateChangeTime = 2;
    [SerializeField] GameObject roomController;

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
        if (checkBool)
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
        if (checkBool)
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
        if (!checkBool)
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
            roomController.GetComponent<RoomColorChange>().roomGreen();
            roomController.GetComponent<GlobalButtonEnableDisable>().ActivateNextRoomButtons();
        }
        else
        {
            stateCheck = 0;
            puzzlePassed = false;
            roomController.GetComponent<RoomColorChange>().roomRed();
        }
        roomController.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
    }

    public bool CheckPuzzlePassed()
    {
        return puzzlePassed;
    }

    private void CheckOutputPower()
    {
        checkBool = outputBoxA.GetComponent<OutputPower>().CheckPowered();
    }
}
