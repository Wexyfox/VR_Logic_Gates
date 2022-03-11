using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestZoneRoom : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
    }
}
