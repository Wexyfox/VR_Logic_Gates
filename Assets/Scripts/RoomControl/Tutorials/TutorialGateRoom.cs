using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialGateRoom : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
    }
}
