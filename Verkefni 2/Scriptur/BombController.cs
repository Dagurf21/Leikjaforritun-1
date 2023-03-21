using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Deduct one coin from the player's score
            GameControllerLeikur.Instance.AddScore(-1);

            // Destroy the bomb
            Destroy(gameObject);
        }
    }
}
