using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMEC : MonoBehaviour
{
    private Rigidbody rb;
    public float turnSpeed = 50f;
  
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

       
    }
}
