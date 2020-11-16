﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float maxspeed = 10f;
    public GameObject cam;
    public GameObject rig;
    public Rigidbody rb; 
    
    void FixedUpdate()
    {
        float side = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        Forward(forward);
        Side(side);
        
        if (rb.velocity.x > maxspeed)
        {
            rb.velocity = new Vector3(maxspeed, rb.velocity.y, rb.velocity.z);
        }
        else if (rb.velocity.x < -maxspeed)
        {
            rb.velocity = new Vector3(-maxspeed, rb.velocity.y, rb.velocity.z);
        }
        if (rb.velocity.z > maxspeed)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, maxspeed);
        }
        if (rb.velocity.z < -maxspeed)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -maxspeed);
        }

        //rig.transform.localPosition = new Vector3(0, 0, 0);
    }
    void Forward(float f)
    {
        Vector3 location = transform.position;
        Vector3 dir = cam.transform.forward;

        dir.y = 0;
        //location += (f * Time.fixedDeltaTime * dir * speed);
        rb.velocity += (f * Time.fixedDeltaTime * dir * speed);
        
        //transform.position = location;
    }
    void Side(float f)
    {
        Vector3 location = transform.position;
        Vector3 dir = cam.transform.right;

        dir.y = 0;
        //location += (f * Time.fixedDeltaTime * dir * speed);
        rb.velocity += (f * Time.fixedDeltaTime * dir * speed);
        //transform.position = location;
    }

}
