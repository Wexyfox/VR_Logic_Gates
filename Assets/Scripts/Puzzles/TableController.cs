using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    [SerializeField] GameObject tables;
    private string temporaryString = null;
    private string temporaryNumber = null;
    private string passStateString = "PassState";
    private string failStateString = "FailState";

    public void PassState(int passStateNumber)
    {
        temporaryNumber = passStateNumber.ToString();
        temporaryString = string.Concat(passStateString, temporaryNumber);
        tables.BroadcastMessage(temporaryString);
    }

    public void FailState(int failStateNumber)
    {
        temporaryNumber = failStateNumber.ToString();
        temporaryString = string.Concat(failStateString, temporaryNumber);
        tables.BroadcastMessage(temporaryString);
    }

    public void ResetTable()
    {
        tables.BroadcastMessage("ResetTable");
    }
}
