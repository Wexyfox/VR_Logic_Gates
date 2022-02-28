using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapping : MonoBehaviour
{
    public void ReleaseSnapping() 
    {
        float rotationX = Mathf.Round(transform.eulerAngles.x / 90) * 90;
        float rotationY = Mathf.Round(transform.eulerAngles.y / 90) * 90;
        float rotationZ = Mathf.Round(transform.eulerAngles.z / 90) * 90;

        transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);

        float snappingX = Mathf.Round(transform.position.x / 0.25f) * 0.25f;
        float snappingY = Mathf.Round(transform.position.y / 0.25f) * 0.25f;
        float snappingZ = Mathf.Round(transform.position.z / 0.25f) * 0.25f;

        transform.position = new Vector3(snappingX, snappingY, snappingZ);
    }
}
