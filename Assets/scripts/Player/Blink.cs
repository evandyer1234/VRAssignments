using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public GameObject left;
    public GameObject right;

    public float MaxTime = 6f;
    public float MinTime = 3f;
    public float blinktime = 0.1f;
    public float closescale = 0.2f;

    float current;
    float originalscale;

    IEnumerator coroutine;

    void Start()
    {
        ResetCounter();
        originalscale = left.transform.localScale.y;
    }

    
    void FixedUpdate()
    {
        current -= Time.fixedDeltaTime;
        if (current <= 0)
        {
            ResetCounter();
            Close();
            coroutine = Open();
            StartCoroutine(coroutine);
           
        }
    }

    public void ResetCounter()
    {
        current = Random.Range(MinTime, MaxTime);        
    }

    public void Close()
    {
        left.transform.localScale = new Vector3(left.transform.localScale.x, closescale, left.transform.localScale.z);
        right.transform.localScale = new Vector3(left.transform.localScale.x, closescale, left.transform.localScale.z);
    }

    public IEnumerator Open()
    {        
        yield return new WaitForSeconds(blinktime);
        
        left.transform.localScale = new Vector3(left.transform.localScale.x, originalscale, left.transform.localScale.z);
        right.transform.localScale = new Vector3(left.transform.localScale.x, originalscale, left.transform.localScale.z);        
    }
}
