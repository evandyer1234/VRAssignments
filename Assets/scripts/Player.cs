using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float maxspeed = 10f;
    public GameObject cam;
    public GameObject rig;
    public Rigidbody rb;
    public GameObject grav;
    
    void Update()
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
        else if (rb.velocity.z < -maxspeed)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -maxspeed);
        }

        rig.transform.localPosition = new Vector3(0, 0, 0);
        /*
        if (transform.rotation != grav.transform.rotation)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, grav.transform.rotation, 0.1f);
        }
        */
    }
    void Forward(float f)
    {
        Vector3 location = transform.position;
        Vector3 dir = cam.transform.forward;

        dir.y = 0;
        
        rb.velocity += (f * Time.fixedDeltaTime * dir * speed);
        
        
    }
    void Side(float f)
    {
        Vector3 location = transform.position;
        Vector3 dir = cam.transform.right;

        dir.y = 0;
        
        rb.velocity += (f * Time.fixedDeltaTime * dir * speed);
        
    }

}
