using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANDTutorial : MonoBehaviour
{
    private int stateChangeTime = 2;
    private int roomColorChangeTime = 5;

    [SerializeField] Material defaultMaterial;
    [SerializeField] Material passMaterial;
    [SerializeField] Material failMaterial;

    [SerializeField] GameObject inputBoxA;
    [SerializeField] GameObject inputBoxB;
    [SerializeField] GameObject outputBoxA;
    private bool puzzlePassed = false;

    [SerializeField] GameObject roomWall1;
    [SerializeField] GameObject roomWall2;
    [SerializeField] GameObject roomWall3;
    [SerializeField] GameObject roomWall4;

    private int stateCheck = 0;

    public void puzzleCheck()
    {
        Invoke("stateCheck1", stateChangeTime);
    }

    private void stateCheck1()
    {
        inputBoxA.GetComponent<InputPower>().PowerOn();
        inputBoxB.GetComponent<InputPower>().PowerOn();
        if (outputBoxA.GetComponent<OutputPower>().CheckPowered())
        {
            stateCheck += 1;
        }
        Invoke("stateCheck2", stateChangeTime);
    }

    private void stateCheck2()
    {
        inputBoxA.GetComponent<InputPower>().PowerOff();
        inputBoxB.GetComponent<InputPower>().PowerOn();
        if (!outputBoxA.GetComponent<OutputPower>().CheckPowered())
        {
            stateCheck += 1;
        }
        Invoke("stateCheck3", stateChangeTime);
    }
    private void stateCheck3()
    {
        inputBoxA.GetComponent<InputPower>().PowerOn();
        inputBoxB.GetComponent<InputPower>().PowerOff();
        if (!outputBoxA.GetComponent<OutputPower>().CheckPowered())
        {
            stateCheck += 1;
        }
        Invoke("stateCheck4", stateChangeTime);
    }
    private void stateCheck4()
    {
        inputBoxA.GetComponent<InputPower>().PowerOff();
        inputBoxB.GetComponent<InputPower>().PowerOff();
        if (!outputBoxA.GetComponent<OutputPower>().CheckPowered())
        {
            stateCheck += 1;
        }
        Invoke("ANDPowerCheck", stateChangeTime);
    }

    private void ANDPowerCheck()
    {
        if (stateCheck == 4)
        {
            puzzlePassed = true;
            roomWall1.GetComponent<MeshRenderer>().sharedMaterial = passMaterial;
            roomWall2.GetComponent<MeshRenderer>().sharedMaterial = passMaterial;
            roomWall3.GetComponent<MeshRenderer>().sharedMaterial = passMaterial;
            roomWall4.GetComponent<MeshRenderer>().sharedMaterial = passMaterial;
            Invoke("RoomColorReset", roomColorChangeTime);
        }
        else
        {
            stateCheck = 0;
            Debug.Log("puzzle failed");
            roomWall1.GetComponent<MeshRenderer>().sharedMaterial = failMaterial;
            roomWall2.GetComponent<MeshRenderer>().sharedMaterial = failMaterial;
            roomWall3.GetComponent<MeshRenderer>().sharedMaterial = failMaterial;
            roomWall4.GetComponent<MeshRenderer>().sharedMaterial = failMaterial;
            Invoke("RoomColorReset", roomColorChangeTime);
        }
    }

    private void RoomColorReset()
    {
        roomWall1.GetComponent<MeshRenderer>().sharedMaterial = defaultMaterial;
        roomWall2.GetComponent<MeshRenderer>().sharedMaterial = defaultMaterial;
        roomWall3.GetComponent<MeshRenderer>().sharedMaterial = defaultMaterial;
        roomWall4.GetComponent<MeshRenderer>().sharedMaterial = defaultMaterial;
    }

    public bool CheckPuzzlePassed()
    {
        return puzzlePassed;
    }
}
