using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XORPowerController : MonoBehaviour
{
    private int activeColliderNumber = 0;
    private bool active = false;
    private bool inputA = false;
    private bool inputB = false;

    public void SetPower(string givenInput)
    {
        if (givenInput == "GateInput A")
        {
            inputA = true;
        }
        else if (givenInput == "GateInput B")
        {
            inputB = true;
        }
        updateOutputBroadcast();
    }

    public void StopPower(string givenInput)
    {
        if (givenInput == "GateInput A")
        {
            inputA = false;
        }
        else if (givenInput == "GateInput B")
        {
            inputB = false;
        }
        updateOutputBroadcast();
    }

    public void SetActive()
    {
        active = true;
        SendMessageUpwards("ActiveGlowOn");
    }

    public void SetInactive()
    {
        active = false;
        StopPower("GateInput A");
        StopPower("GateInput B");
        BroadcastMessage("StopPowerOutput");
        SendMessageUpwards("ActiveGlowOff");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            activeColliderNumber += 1;
            if (activeColliderNumber == 4)
            {
                SetActive();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            activeColliderNumber -= 1;
            if (activeColliderNumber != 4)
            {
                SetInactive();
            }
        }
    }

    private void updateOutputBroadcast()
    {
        if (active == true)
        {
            if (inputA ^ inputB)
            {
                //Debug.Log("Power controller gave power to output");
                BroadcastMessage("PowerOutput");
            }
            else
            {
                BroadcastMessage("StopPowerOutput");
            }
        }
    }

    private void FixedUpdate()
    {
        updateOutputBroadcast();
    }
}