using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialWireRoom : MonoBehaviour
{
    private GameObject[] buttons;

    private void Start()
    {
        buttons = GameObject.FindGameObjectsWithTag("Button");

        foreach (GameObject button in buttons)
        {
            button.GetComponent<ButtonControllerVR>().ButtonEnable();
        }
    }
}
