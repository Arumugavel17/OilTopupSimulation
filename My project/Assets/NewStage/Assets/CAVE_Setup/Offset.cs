using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour
{
    public GameObject Camera1, Camera2, Camera3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera1 = GameObject.Find("Center Eye For: FloorDisp");
        Camera2 = GameObject.Find("Left Eye For: FloorDisp");
        Camera3 = GameObject.Find("Right Eye For: FloorDisp");

        if (true)
        {
            Camera1.transform.localPosition = new Vector3(0, 0.05f, 0.05f);
            Camera2.transform.localPosition = new Vector3(-0.05f, 0.05f, 0.05f);
            Camera3.transform.localPosition = new Vector3(0.05f, 0.05f, 0.05f);
        }
    }
}
