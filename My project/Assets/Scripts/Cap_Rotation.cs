using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Cap_Rotation : MonoBehaviour
{
    public Transform knob; // The knob object to rotate
    public Transform pivotPoint; // The fixed pivot point of rotation
    public float rotationSpeed = 50f; // Speed of rotation
    public float minAngle = -90f; // Minimum rotation angle
    public float maxAngle = 90f; // Maximum rotation angle

    private float currentAngle;

    void Update()
    {
        // Get input from controller
        float rotationInput = Input.GetAxis("Horizontal");

        // Calculate rotation amount
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;

        // Update current angle
        currentAngle += rotationAmount;

        // Clamp the angle within the specified range
        currentAngle = Mathf.Clamp(currentAngle, minAngle, maxAngle);

        // Rotate the knob around the pivot point
        Vector3 rotationAxis = pivotPoint.forward; // You can change this axis to fit your setup
        knob.rotation = Quaternion.AngleAxis(currentAngle, rotationAxis) * pivotPoint.rotation;
    }
}
