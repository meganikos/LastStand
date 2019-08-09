using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Red : MonoBehaviour
{
    public GameObject Red_enemy;
    float randX;
    Vector2 Spawnpoint;
    //public float spawnRate = 2f; 
   /* float nextspawn = 0f; */// Float variable represent time/spawn of enemies.
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.3f, 0.3f);//Spawn Rate of enemies
    }
    private void Update()
    {
        
    }
   

    private void SpawnEnemy()
    {
        randX = randX = Random.Range(-20.4f, 20.4f); // The spreadth of enemies.
        Spawnpoint = new Vector2(randX, transform.position.y);
        Instantiate(Red_enemy, Spawnpoint, Quaternion.identity);
        //if (Time.time > nextspawn)
        //{
        //    nextspawn = Time.time + spawnRate;
        //    randX = randX = Random.Range(-20.4f, 20.4f); // The spreadth of enemies.
        //    Spawnpoint = new Vector2(randX, transform.position.y);
        //    Instantiate(enemy, Spawnpoint, Quaternion.identity);
        //}
    }
}
