using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class FakePin : MonoBehaviour
{
    [SerializeField] private GameObject Original;
    public void DeactivateFake(SelectEnterEventArgs selectEnterEventArgs)
    {
        Debug.Log(gameObject);
        gameObject.SetActive(false);
        Original.gameObject.SetActive(true);
    }
}
