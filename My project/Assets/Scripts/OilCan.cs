using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilCan : MonoBehaviour
{
    [SerializeField] private Transform OilCanCap;
    [SerializeField] private GameObject Oil; 
    private bool CapRemoved;
    public void Update()
    {
        if (CapRemoved)
        {
            if(transform.rotation.eulerAngles.y < -63)
            {

            }
        }
    }
}
