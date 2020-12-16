using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    
    public void Spin(float speed)
    {
        transform.Rotate(speed * Time.fixedDeltaTime * Vector3.up);
    }
}
