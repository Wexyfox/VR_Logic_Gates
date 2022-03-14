using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPuzzleRoom : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
    }
}
