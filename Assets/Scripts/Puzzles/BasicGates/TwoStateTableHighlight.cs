using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoStateTableHighlight : MonoBehaviour
{
    [SerializeField] GameObject passState1;
    [SerializeField] GameObject passState2;

    [SerializeField] GameObject failState1;
    [SerializeField] GameObject failState2;

    private void Start()
    {
        ResetTable();
    }

    public void ResetTable()
    {
        passState1.SetActive(false);
        passState2.SetActive(false);

        failState1.SetActive(false);
        failState2.SetActive(false);
    }

    public void PassState1()
    {
        passState1.SetActive(true);
    }

    public void PassState2()
    {
        passState2.SetActive(true);
    }

    public void FailState1()
    {
        failState1.SetActive(true);
    }

    public void FailState2()
    {
        failState2.SetActive(true);
    }
}
