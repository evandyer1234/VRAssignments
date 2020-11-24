using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCam : MonoBehaviour
{
    public GameObject Player;

    Vector3 MoveDirection;

    public bool reflectx = true;
    public bool reflecty = false;
    public bool reflectz = false;
    
    
    void Update()
    {
        MoveDirection = (Player.transform.position - transform.position).normalized;

        if (reflectx)
        {
            MoveDirection.x *= -1;
        }
        if (reflectz)
        {
            MoveDirection.z *= -1;
        }
        if (reflecty)
        {
            MoveDirection.y *= -1;
        }
        
        gameObject.transform.forward = MoveDirection;
    }
}
