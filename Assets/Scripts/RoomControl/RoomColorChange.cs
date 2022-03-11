using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomColorChange : MonoBehaviour
{
    [SerializeField] GameObject roomWall1;
    [SerializeField] GameObject roomWall2;
    [SerializeField] GameObject roomWall3;
    [SerializeField] GameObject roomWall4;

    [SerializeField] Material defaultMaterial;
    [SerializeField] Material passMaterial;
    [SerializeField] Material failMaterial;

    private int roomColorChangeTime = 5;

    public void roomGreen()
    {
        roomWall1.GetComponent<MeshRenderer>().sharedMaterial = passMaterial;
        roomWall2.GetComponent<MeshRenderer>().sharedMaterial = passMaterial;
        roomWall3.GetComponent<MeshRenderer>().sharedMaterial = passMaterial;
        roomWall4.GetComponent<MeshRenderer>().sharedMaterial = passMaterial;
        Invoke("RoomColorReset", roomColorChangeTime);
    }

    public void roomRed()
    {
        roomWall1.GetComponent<MeshRenderer>().sharedMaterial = failMaterial;
        roomWall2.GetComponent<MeshRenderer>().sharedMaterial = failMaterial;
        roomWall3.GetComponent<MeshRenderer>().sharedMaterial = failMaterial;
        roomWall4.GetComponent<MeshRenderer>().sharedMaterial = failMaterial;
        Invoke("RoomColorReset", roomColorChangeTime);
    }

    private void RoomColorReset()
    {
        roomWall1.GetComponent<MeshRenderer>().sharedMaterial = defaultMaterial;
        roomWall2.GetComponent<MeshRenderer>().sharedMaterial = defaultMaterial;
        roomWall3.GetComponent<MeshRenderer>().sharedMaterial = defaultMaterial;
        roomWall4.GetComponent<MeshRenderer>().sharedMaterial = defaultMaterial;
    }
}
