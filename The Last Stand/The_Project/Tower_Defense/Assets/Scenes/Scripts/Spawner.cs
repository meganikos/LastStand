﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 Spawnpoint;
    public float spawnRate = 2f; // The amount of enemies spawn/sec.
    float nextspawn = 0f; // Just a float variable to represent time/spawn of enemies.
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 0.5f);
    }
    //private void Update()
    //{
    //    SpawnEnemy();
    //}

    private void SpawnEnemy()
    {
        randX = randX = Random.Range(-20.4f, 20.4f); // The spreadth of enemies.
        Spawnpoint = new Vector2(randX, transform.position.y);
        Instantiate(enemy, Spawnpoint, Quaternion.identity);
        //if (Time.time > nextspawn)
        //{
        //    nextspawn = Time.time + spawnRate;
        //    randX = randX = Random.Range(-20.4f, 20.4f); // The spreadth of enemies.
        //    Spawnpoint = new Vector2(randX, transform.position.y);
        //    Instantiate(enemy, Spawnpoint, Quaternion.identity);
        //}
    }
}
