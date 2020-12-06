using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    public Vector3 gravity;
    public GameObject grav;
    
    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Physics.gravity = gravity;
        other.transform.eulerAngles = Physics.gravity;
    }
}
