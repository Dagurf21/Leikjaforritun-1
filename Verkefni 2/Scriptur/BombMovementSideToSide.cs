using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovementSideToSide : MonoBehaviour
{
    public float amplitude = 1f;
    public float frequency = 1f;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float offset = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = startPosition + new Vector3(offset, 0f, 0f);
    }
}
