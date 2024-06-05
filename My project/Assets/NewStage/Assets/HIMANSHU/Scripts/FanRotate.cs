using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{
    public Vector3 vec;
    public float rotateSpeed;    

    private void Update()
    {
        transform.Rotate(vec * rotateSpeed * Time.deltaTime);        
    }
}
