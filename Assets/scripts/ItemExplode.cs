using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemExplode : Item
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        Enemy enemy = collision.gameObject.GetComponentInParent<Enemy>();
        if (enemy != null)
        {
            Debug.Log("hit enemy");
            GameObject clone;
            clone = Instantiate(enemy.wreck, enemy.transform.position, enemy.transform.rotation);
            Destroy(enemy.current);
            Destroy(enemy.gameObject);
            Destroy(this.gameObject);
        }
       
    }
}
