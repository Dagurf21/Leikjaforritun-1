using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TMPro er fyrir Unity UI - Fyrir counterinn
using TMPro;


public class DetectCollisions : MonoBehaviour
{
    //Fastar fyrir count og Counter UI
	public TextMeshProUGUI countText;
	public GameObject winTextObject;

    private int count;

    // Start is called before the first frame update
    void Start(){
        //Counter byrjar á 0
        count = 0;  
        SetCountText();
        winTextObject.SetActive(false);

    }

    // Update is called once per frame
    void Update(){
        
    }

    //Þegar eitthvað rekst við hvort annað hverfa þau
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        Destroy(other.gameObject);

        //Bætir við +1 í counter hvert skipti sem eitthvað rekst á
        count = count + 1;

        // Kallar á fall
        SetCountText ();
    }

    void SetCountText(){
        countText.text = "Score: " + count.ToString();
        if (count >= 10){
            winTextObject.SetActive(true);
        }
    }
}
