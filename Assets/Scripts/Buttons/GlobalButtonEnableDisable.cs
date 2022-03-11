using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalButtonEnableDisable : MonoBehaviour
{
    private GameObject[] buttons;

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
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
            if (!(button.name == "NextRoomCollider"))
            {
                button.GetComponent<ButtonControllerVR>().ButtonEnable();
            }
        }
    }

    public void ActivateNextRoomButtons()
    {
        foreach (GameObject button in buttons)
        {
            if (button.name == "NextRoomCollider")
            {
                button.GetComponent<ButtonControllerVR>().ButtonEnable();
            }
        }
    }
}
