using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : Enemy
{  
    void FixedUpdate()
    {
        if (!alert)
        {
            transform.localEulerAngles += new Vector3(0, rotationrate, 0) * Time.fixedDeltaTime;
            leftwheel.Spin(-40f);
            rightwheel.Spin(-40f);
            Vector3 location = transform.position;

            location += (speed * Time.fixedDeltaTime * transform.right);


            transform.position = location;
            
        }
    }
}
