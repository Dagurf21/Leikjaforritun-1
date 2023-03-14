using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Fasti fyrir speed
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Svo hlutir fara áfram
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
