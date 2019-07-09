using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    private Rigidbody rb;
    public float tilt = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-tilt, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(tilt, 0, 0);


        }
    }
}
