using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Director : MonoBehaviour
{
    [SerializeField] private GameObject OilPin;
    [SerializeField] private GameObject Containter;
    [SerializeField] private GameObject Socket;

    private void Start()
    {
        Containter.GetComponent<XRGrabInteractable>().enabled = false;
        Socket.GetComponent<XRSocketInteractor>().enabled = false;
    }
}
