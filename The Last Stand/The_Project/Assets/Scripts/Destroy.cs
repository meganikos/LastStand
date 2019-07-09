using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public Text LoseText;
   
    [SerializeField] private int startingHealth = 3;

    void Start()
    {
        //LoseText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void loseText()
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
            
            
            else 
            {
                other.GetComponent<HarmRed>().TakeDamage(); //Take 1 hit for red enemies
                other.GetComponent<Explosion>().explode(); //Red enemies explode afetr they die

            }
            

            Destroy(gameObject); // Destroy bullet after contact with enemy 
           


        }

   }
    
}
