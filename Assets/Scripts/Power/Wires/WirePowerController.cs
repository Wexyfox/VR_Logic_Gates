using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WirePowerController : MonoBehaviour
{
    private bool active = false;

    public void SetPower()
    {
        if (active == true)
        {
            //Debug.Log("Power controller gave power to output");
            BroadcastMessage("PowerOutput");
        }
    }

    public void StopPower()
    {
        //Debug.Log("Power controller stopped power to output");
        BroadcastMessage("StopPowerOutput");
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
}