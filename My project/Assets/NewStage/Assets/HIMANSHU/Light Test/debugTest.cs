using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugTest : MonoBehaviour
{
    private int inttt = 7;
    private int power = 1;
    private string table = "Table Of 7 x ";
    private string isEqaulTwo = " = ";
    private void Start()
    {
        Debug.Log(table + power + " = " + inttt);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            inttt+=7;
            //power++;
            power = 1 + power;
            Debug.Log(table + power + isEqaulTwo + inttt);
        }
    }
}
