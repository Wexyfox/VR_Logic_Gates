using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOutput : MonoBehaviour
{
    GameObject connection = null;
    private bool powered = false;

    public void PowerOutput()
    {
        powered = true;
        //Debug.Log("Gate output colldier attempts power transfer");
        UpdatePowerOutput();
        BroadcastMessage("ActiveGlowOn");
    }

    public void StopPowerOutput()
    {
        powered = false;
        //Debug.Log("Gate output colldier stops power transfer");
        UpdatePowerOutput();
        BroadcastMessage("ActiveGlowOff");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Input")
        {
            connection = other.gameObject;
            UpdatePowerOutput();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == connection)
        {
            if (connection.name == "WireInput")
            {
                connection.GetComponent<WireInput>().PowerWithdrawn();
            }
            else if (connection.name == "GateInput A" | connection.name == "GateInput B")
            {
                connection.GetComponent<GateInput>().PowerWithdrawn();
            }
            connection = null;
        }
    }

    private void UpdatePowerOutput()
    {
        if (connection != null)
        {
            if (powered)
            {
                if (connection.name == "WireInput")
                {
                    connection.GetComponent<WireInput>().ReceivePower();
                }
                else if (connection.name == "GateInput A" | connection.name == "GateInput B")
                {
                    connection.GetComponent<GateInput>().ReceivePower();
                }

            }
            else
            {
                if (connection.name == "WireInput")
                {
                    connection.GetComponent<WireInput>().PowerWithdrawn();
                }
                else if (connection.name == "GateInput A" | connection.name == "GateInput B")
                {
                    connection.GetComponent<GateInput>().PowerWithdrawn();
                }
            }
        }
    }
}
