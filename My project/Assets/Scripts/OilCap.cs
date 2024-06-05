using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System;
using Unity.VisualScripting;
public class OilCap : MonoBehaviour
{
    [SerializeField] private XRGrabInteractable interactable;
    [SerializeField] private Transform OilPin;
    private bool OilPinRaised = false;
    private bool OilPinRotated = false;
    public void Pin(SelectEnterEventArgs selectEnterEventArgs)
    {
        if (!OilPinRaised)
        { 
            OilPinRaised = true;
            OilPin.Rotate(90, 0, 0);
        }
        else if(OilPinRaised && !OilPinRotated) 
        {
            OilPinRotated = true;
            OilPin.Rotate(0,0, -90);
        }
        if(OilPinRaised && OilPinRotated) 
        {
            interactable.enabled = true;
            this.enabled = false;
        }
    }
}
