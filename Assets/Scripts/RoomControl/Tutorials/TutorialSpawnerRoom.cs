using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSpawnerRoom : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
    }
}
