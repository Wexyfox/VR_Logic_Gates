using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOTPowerController : MonoBehaviour
{
    private bool active = false;
    private bool powered = false;

    public void SetPower()
    {
        powered = true;
    }

    public void StopPower()
    {
        powered = false;
    }

    public void SetActive()
    {
        active = true;
        SendMessageUpwards("ActiveGlowOn");
    }

    public void SetInactive()
    {
        active = false;
        StopPower();
        BroadcastMessage("StopPowerOutput");
        SendMessageUpwards("ActiveGlowOff");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            SetActive();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            SetInactive();
        }
    }

    private void updateOutputBroadcast()
    {
        if (active == true)
        {
            if (powered)
            {
                BroadcastMessage("StopPowerOutput");
            }
            else
            {
                BroadcastMessage("PowerOutput");
            }
        }
    }

    private void FixedUpdate()
    {
        updateOutputBroadcast();
    }
}
