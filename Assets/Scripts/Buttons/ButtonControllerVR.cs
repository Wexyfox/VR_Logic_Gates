using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonControllerVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    AudioSource soundEffect;
    private bool isPressed = false;
    private bool buttonEnabled;

    void Start()
    {
        soundEffect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (buttonEnabled)
        {
            if (!isPressed & other.gameObject.tag == "Player")
            {
                button.transform.localPosition = new Vector3(0, 0.004f, 0);
                onPress.Invoke();
                soundEffect.Play();
                isPressed = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            button.transform.localPosition = new Vector3(0, 0.013f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void ButtonEnable()
    {
        button.BroadcastMessage("ActiveGlowOn");
        buttonEnabled = true;
    }

    public void ButtonDisable()
    {
        button.BroadcastMessage("ActiveGlowOff");
        buttonEnabled = false;
    }
}
