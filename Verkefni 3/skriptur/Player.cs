using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Bullet.count >= 1000)//ef player er kominn me� 30 stig b�inn a� vinna
        {
            Ovinur.health = 30;//l�t player hafa 30 � l�f
            Bullet.count = 0;//n�ll stilli stigin
            SceneManager.LoadScene(2);

        }
    }
}
