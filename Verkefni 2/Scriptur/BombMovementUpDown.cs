using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovementUpDown : MonoBehaviour
{
    public float speed = 1.0f;
    public float amplitude = 1.0f;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        float newY = initialPosition.y + amplitude * Mathf.Sin(speed * Time.time);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
