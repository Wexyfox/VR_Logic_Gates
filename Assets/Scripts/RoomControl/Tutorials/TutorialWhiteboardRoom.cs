using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialWhiteboardRoom : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
        gameObject.GetComponent<GlobalButtonEnableDisable>().ActivateNextRoomButtons();
    }
}
