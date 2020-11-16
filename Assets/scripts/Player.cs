using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public GameObject cam;
    public GameObject rig;
 
    
    void FixedUpdate()
    {
        float side = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        Forward(forward);
        Side(side);

        rig.transform.localPosition = new Vector3(0, 0, 0);
    }
    void Forward(float f)
    {
        Vector3 location = transform.position;
        Vector3 dir = cam.transform.forward;

        dir.y = 0;
        location += (f * Time.fixedDeltaTime * dir * speed);
        
        transform.position = location;
    }
    void Side(float f)
    {
        Vector3 location = transform.position;
        Vector3 dir = cam.transform.right;

        dir.y = 0;
        location += (f * Time.fixedDeltaTime * dir * speed);

        transform.position = location;
    }

}
