using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateInput : MonoBehaviour
{
    private bool powered = false;

    public void ReceivePower()
    {
        powered = true;
        //Debug.Log("Gate input collider set power");
        BroadcastMessage("ActiveGlowOn");
        SendMessageUpwards("SetPower",gameObject.name);
    }

    public void PowerWithdrawn()
    {
        powered = false;
        //Debug.Log("Gate input collider stopped power");
        BroadcastMessage("ActiveGlowOff");
        SendMessageUpwards("StopPower", gameObject.name);
    }

    private void FixedUpdate()
    {
        if (powered == true)
        {
            BroadcastMessage("ActiveGlowOn");
            SendMessageUpwards("SetPower", gameObject.name);
        }
        else
        {
            BroadcastMessage("ActiveGlowOff");
            SendMessageUpwards("StopPower", gameObject.name);
        }
    }
}
