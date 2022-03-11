using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPower : MonoBehaviour
{
    [SerializeField] GameObject asignedButton;
    GameObject connection = null;
    private bool powered = false;

    public void PowerToggle()
    {
        if (powered)
        {
            PowerOff();
        }
        else
        {
            PowerOn();
        }
        UpdatePowerOutput();
    }

    private void FixedUpdate()
    {
        if (!powered)
        {
            asignedButton.BroadcastMessage("ActiveGlowOff");
        }
    }

    public void PowerOn()
    {
        powered = true;
        UpdatePowerOutput();
        SendMessageUpwards("ActiveGlowOn");
        asignedButton.BroadcastMessage("ActiveGlowOn");
    }

    public void PowerOff()
    {
        powered = false;
        UpdatePowerOutput();
        SendMessageUpwards("ActiveGlowOff");
        asignedButton.BroadcastMessage("ActiveGlowOff");
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
                    //Debug.Log("Output colldier gave power from power controller");
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
                    //Debug.Log("Output colldier gave power from power controller");
                }
                else if (connection.name == "GateInput A" | connection.name == "GateInput B")
                {
                    connection.GetComponent<GateInput>().PowerWithdrawn();
                }
            }
        }
    }
}