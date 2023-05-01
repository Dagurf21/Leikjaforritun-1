using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    public GameObject sprengjan;
    public static int count;//klasabreyta
    private Text countText;
    void Start()
    {
        rb.velocity = transform.forward * speed;
        countText = GameObject.Find("Text2").GetComponent<Text>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "raudurkassi")
        {
            count += 10;
            Destroy(collision.gameObject);//eyðir kassanum
            //Destroy(gameObject);//eyða kúlunni þarf ekki eyðist eftir 0.5 sek                 
            Sprengja();//framkvæmir sprengju
            countText.text = "stig " + count.ToString();
        }
        if (collision.collider.tag == "gullpeningur")
        {
            count += 500;
            Destroy(collision.gameObject);//eyðir peninginum
            //Destroy(gameObject);//eyða kúlunni þarf ekki eyðist eftir 0.5 sek                 
            Sprengja();//framkvæmir sprengju
            countText.text = "stig " + count.ToString();
        }

    }
    void Sprengja()
    {
        Instantiate(sprengjan, transform.position, transform.rotation);
    }
}
