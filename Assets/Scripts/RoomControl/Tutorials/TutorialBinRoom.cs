using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBinRoom : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
        gameObject.GetComponent<GlobalButtonEnableDisable>().ActivateNextRoomButtons();
    }
}
