using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialWireRoom : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
    }
}
