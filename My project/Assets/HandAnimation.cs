using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] private InputActionProperty triggeraction;
    [SerializeField] private InputActionProperty gripaction;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Trigger", triggeraction.action.ReadValue<float>());
        animator.SetFloat("Grip", gripaction.action.ReadValue<float>());
    }
}
