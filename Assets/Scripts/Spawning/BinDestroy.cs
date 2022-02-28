using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gate" | other.gameObject.tag == "Wire")
        {
            Destroy(other.gameObject);
        }
    }
}
