using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireTutorial : MonoBehaviour
{
    private int stateChangeTime = 2;
    [SerializeField] GameObject roomController;

    [SerializeField] GameObject inputBoxA;
    [SerializeField] GameObject outputBoxA;

    private bool checkBool;

    private int stateCheck = 0;

    public void PuzzleCheck()
    {
        Invoke("StateSet1", stateChangeTime);
    }

    private void StateSet1()
    {
        inputBoxA.GetComponent<InputPower>().PowerOn();
        Invoke("CheckSet1", stateChangeTime);
    }

    private void CheckSet1()
    {
        CheckOutputPower();
        if (checkBool)
        {
            stateCheck += 1;
        }
        StateSet2();
    }

    private void StateSet2()
    {
        inputBoxA.GetComponent<InputPower>().PowerOff();
        Invoke("CheckSet2", stateChangeTime);
    }

    private void CheckSet2()
    {
        CheckOutputPower();
        if (!checkBool)
        {
            stateCheck += 1;
        }
        WireTutorialPowerCheck();
    }

    private void WireTutorialPowerCheck()
    {
        if (stateCheck == 2)
        {
            stateCheck = 0;
            roomController.GetComponent<RoomColorChange>().roomGreen();
            roomController.GetComponent<GlobalButtonEnableDisable>().ActivateNextRoomButtons();
        }
        else
        {
            stateCheck = 0;
            roomController.GetComponent<RoomColorChange>().roomRed();
        }
        roomController.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
    }

    private void CheckOutputPower()
    {
        checkBool = outputBoxA.GetComponent<OutputPower>().CheckPowered();
    }
}
