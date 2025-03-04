﻿using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;

    // Add a float variable  

    public float forwardForce = 2000f;
    public float sidewaysForce =  500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forward force
        //rb.AddForce(0, 0, forwardForce);
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
                
        }
    }
}  
