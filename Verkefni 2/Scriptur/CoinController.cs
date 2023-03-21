using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinController : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public int coinValue = 1;
    public TextMeshProUGUI scoreText;
    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Choho");
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("Coin collected!");
            GameControllerLeikur.Instance.AddScore(coinValue);
            Destroy(gameObject);
        }

        //
    }
}
