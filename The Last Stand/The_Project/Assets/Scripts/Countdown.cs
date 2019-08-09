using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float Timer = 10f;
    private Text Timesec;
  

    
    void Start()
    {
        Timesec = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        Timesec.text = Timer.ToString("0");
        if (Timer <= 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       



    }
   
}
