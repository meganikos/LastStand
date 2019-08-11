using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    GameObject Boss;
   
    [SerializeField] private int startingHealth = 3;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
   
   

   private void OnTriggerEnter(Collider other)
   {
        if (other.gameObject.CompareTag("destroy"))
        {
            if (other.name.Contains("Green"))
            {
                other.GetComponent<HarmGreen>().TakeDamage();  //Take 3 hits for green enemies
                other.GetComponent<Explosion>().explode();    // Green enemies explode after they die
                
            }
            if (other.name.Contains("Red"))
            {
                other.GetComponent<HarmRed>().TakeDamage();
                other.GetComponent<Explosion>().explode();

            }


            if (other.name.Contains("Boss"))
            {
                other.GetComponent<HarmBoss>().TakeDamage(); 
                other.GetComponent<Explosion>().explode(); 
                

            }


            Destroy(gameObject); // Destroy bullet after contact with enemy 
           


        }

   }
    
}
