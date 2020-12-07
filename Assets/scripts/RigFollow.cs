using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 pos;
    

    
    void Update()
    {
        transform.position = target.transform.position + pos;
    }
}
