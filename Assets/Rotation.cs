using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Vector3 _originalPosition;
    [SerializeField] private float wobbleSpeed = 2.0f;
    [SerializeField] private float wobbleAmount = 0.1f;

    private void Start()
    {
        _originalPosition = transform.position;
    }

    private void Update()
    {
        // Apply a wobbly effect to the object's position
        var xOffset = Mathf.Sin(Time.time * wobbleSpeed) * wobbleAmount;
        var yOffset = Mathf.Cos(Time.time * wobbleSpeed) * wobbleAmount;
        transform.position = _originalPosition + new Vector3(xOffset, yOffset, 0f);

        // Rotate the object slightly
        transform.Rotate(Vector3.up, Time.deltaTime * 20f);
    }
}
