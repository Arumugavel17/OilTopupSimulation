using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cal : MonoBehaviour
{
    private float final_n;
    public float start_n;
    public float multiply;
    private void Start()
    {
        Debug.Log(start_n);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            multiply = 1f + multiply;            
            final_n = start_n * multiply;
            Debug.Log(final_n);
        }
    }    
}
