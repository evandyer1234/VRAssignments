using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaporPanel : MonoBehaviour
{
    AudioSource source;
    public AudioClip clip;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Item i = other.gameObject.GetComponent<Item>();

        if (i != null)
        {
            source.PlayOneShot(clip);
            if (i.spawner != null)
            {
                i.spawner.Spawn();
            }
            Destroy(other.gameObject);
        }
    }
}
