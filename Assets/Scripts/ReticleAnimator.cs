using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleAnimator : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f; // Degrees per second

    [SerializeField] float scaleAmplitude = 0.2f; // Amount to scale up/down
    [SerializeField] float scaleSpeed = 2f;       // Speed of scaling

    Vector3 initialScale;

    void Start()
    {
        // Store the initial scale of the reticle
        initialScale = transform.localScale;
    }

    void Update()
    {
        AnimateRotation();
        AnimateScaling();
    }

    private void AnimateRotation()
    {
        // Rotate around the Y-axis 
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        // Debug.Log($"Rotating reticle at speed: {rotationSpeed * Time.deltaTime}");
        Debug.Log($"Transform degrees: {transform.rotation.eulerAngles}");
    }

    private void AnimateScaling()
    {
        // Oscillate the scale
        float scaleOffset = Mathf.Sin(Time.time * scaleSpeed) * scaleAmplitude;
        transform.localScale = initialScale + Vector3.one * scaleOffset;
    }
}
