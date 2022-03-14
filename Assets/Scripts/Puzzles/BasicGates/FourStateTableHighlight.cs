using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourStateTableHighlight : MonoBehaviour
{
    [SerializeField] GameObject passState1;
    [SerializeField] GameObject passState2;
    [SerializeField] GameObject passState3;
    [SerializeField] GameObject passState4;

    [SerializeField] GameObject failState1;
    [SerializeField] GameObject failState2;
    [SerializeField] GameObject failState3;
    [SerializeField] GameObject failState4;

    private void Start()
    {
        ResetTable();
    }

    public void ResetTable()
    {
        passState1.SetActive(false);
        passState2.SetActive(false);
        passState3.SetActive(false);
        passState4.SetActive(false);

        failState1.SetActive(false);
        failState2.SetActive(false);
        failState3.SetActive(false);
        failState4.SetActive(false);
    }

    public void PassState1()
    {
        passState1.SetActive(true);
    }

    public void PassState2()
    {
        passState2.SetActive(true);
    }

    public void PassState3()
    {
        passState3.SetActive(true);
    }

    public void PassState4()
    {
        passState4.SetActive(true);
    }

    public void FailState1()
    {
        failState1.SetActive(true);
    }

    public void FailState2()
    {
        failState2.SetActive(true);
    }

    public void FailState3()
    {
        failState3.SetActive(true);
    }

    public void FailState4()
    {
        failState4.SetActive(true);
    }
}
