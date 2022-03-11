using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSplitterRoom : MonoBehaviour
{    private void Start()
    {
        gameObject.GetComponent<GlobalButtonEnableDisable>().TestButtonEnable();
    }
}
