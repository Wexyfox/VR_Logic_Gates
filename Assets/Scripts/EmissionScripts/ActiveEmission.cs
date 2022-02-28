using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveEmission : MonoBehaviour
{
    [SerializeField] private Material emissiveMaterial;
    [SerializeField] private Renderer glowObject;

    private void Start()
    {
        emissiveMaterial = glowObject.GetComponent<Renderer>().material;
    }

    public void ActiveGlowOn()
    {
        emissiveMaterial.EnableKeyword("_EMISSION");
    }

    public void ActiveGlowOff()
    {
        emissiveMaterial.DisableKeyword("_EMISSION");
    }
}
