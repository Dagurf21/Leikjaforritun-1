using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Bullet.count >= 1000)//ef player er kominn með 30 stig búinn að vinna
        {
            Ovinur.health = 30;//læt player hafa 30 í líf
            Bullet.count = 0;//núll stilli stigin
            SceneManager.LoadScene(2);

        }
    }
}
