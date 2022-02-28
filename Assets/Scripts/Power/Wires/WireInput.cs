using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireInput : MonoBehaviour
{
    private bool powered = false;

    public void ReceivePower()
    {
        powered = true;
        //Debug.Log("Input collider set power");
        BroadcastMessage("ActiveGlowOn");
        SendMessageUpwards("SetPower");
    }

    public void PowerWithdrawn()
    {
        powered = false;
        //Debug.Log("Input collider stopped power");
        BroadcastMessage("ActiveGlowOff");
        SendMessageUpwards("StopPower");
    }

    private void FixedUpdate()
    {
        if (powered == true)
        {
            BroadcastMessage("ActiveGlowOn");
            SendMessageUpwards("SetPower");
        }
        else 
        {
            BroadcastMessage("ActiveGlowOff");
            SendMessageUpwards("StopPower");
        }
    }
}
