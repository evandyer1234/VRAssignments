using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRotate : MonoBehaviour
{
    public float speed = 100f;
    

   
    void FixedUpdate()
    {
        transform.Rotate(speed * Time.fixedDeltaTime * Vector3.up);
    }
}
