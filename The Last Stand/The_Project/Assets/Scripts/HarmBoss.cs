﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HarmBoss : MonoBehaviour
{
    public int startingHealth = 20; 

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage()
    {
        startingHealth--;

        if (startingHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(5);
        }



    }

}
