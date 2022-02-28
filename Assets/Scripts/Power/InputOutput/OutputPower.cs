using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputPower : MonoBehaviour
{
    private bool powered = false;
    public void SetPower()
    {
        powered = true;
        SendMessageUpwards("ActiveGlowOn");
    }

    public void StopPower()
    {
        powered = false;
        SendMessageUpwards("ActiveGlowOff");
    }

    private void FixedUpdate()
    {
        if (powered == true)
        {
            SendMessageUpwards("ActiveGlowOn");
        }
        else
        {
            SendMessageUpwards("ActiveGlowOff");
        }
    }

    public bool CheckPowered()
    {
        return powered;
    }
}
