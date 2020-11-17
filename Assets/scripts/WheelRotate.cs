﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    
    public void Spin(float speed)
    {
        transform.eulerAngles += new Vector3(speed, 0, 0) * Time.fixedDeltaTime;
    }
}
