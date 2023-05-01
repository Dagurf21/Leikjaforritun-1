using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kassi : MonoBehaviour
{

    private void Update()
    {
        if (transform.position.y < -10)//sett á kassan til að eyða honum ef hann fer framm af heimi
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

}
