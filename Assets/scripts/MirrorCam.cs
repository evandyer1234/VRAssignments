using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCam : MonoBehaviour
{
    public GameObject Player;
    Vector3 MoveDirection;
    public bool reflectz = false;
    
    void Update()
    {
        MoveDirection = (Player.transform.position - transform.position).normalized;
        
        MoveDirection.x *= -1;
        if (reflectz)
        {
            MoveDirection.z *= -1;
        }
        
        gameObject.transform.forward = MoveDirection;
    }
}
