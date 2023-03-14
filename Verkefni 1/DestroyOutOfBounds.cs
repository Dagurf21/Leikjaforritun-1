using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Fastar
    private float topBound = 35;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ef eitthvað fer ofar en 35 þá verður því eytt.
        if (transform.position.z > topBound){
            Destroy(gameObject);
        } 
        // Ef eitthvað fer lengra en -10 þá er því eytt
        else if (transform.position.z < lowerBound)
        {
            // Game over ef dýr kemst framhjá.
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        
    }
}
