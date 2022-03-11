using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalButtonEnableDisable : MonoBehaviour
{
    private GameObject[] buttons;

    void Start()
    {
        buttons = GameObject.FindGameObjectsWithTag("Button");
    }

    public void TestButtonDisable()
    {
        foreach (GameObject button in buttons)
        {
            button.GetComponent<ButtonControllerVR>().ButtonDisable();
        }
    }

    public void TestButtonEnable()
    {
        foreach (GameObject button in buttons)
        {
            button.GetComponent<ButtonControllerVR>().ButtonEnable();
        }
    }
}
