using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Light1 : MonoBehaviour
{
    public Material light_normal;
    public Material light_glow;
    public GameObject object_light;
    public bool istrue = false;

    public Animator animator;
    public string triggerName1;
    public string triggerName2;
    

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {            
            if(istrue != false)
            {
                object_light.GetComponent<Renderer>().material = light_glow;
                istrue = false;
                animator.SetTrigger(triggerName1);
                //animator.CrossFade("Lighrt Move", 0.2f);
                Debug.Log("UP");
            }
            else
            {
                object_light.GetComponent<Renderer>().material = light_normal;
                istrue = true;
                animator.SetTrigger(triggerName2);
                //animator.CrossFade("Down", 0.2f);
                Debug.Log("Down");
            }
        }
    }
}
