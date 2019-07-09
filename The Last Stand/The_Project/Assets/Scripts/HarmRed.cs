using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmRed : MonoBehaviour
{
    [SerializeField] private int startingHealth = 1; // 1 hits

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
        }

    }

}
