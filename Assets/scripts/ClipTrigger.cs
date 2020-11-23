using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipTrigger : MonoBehaviour
{
    public AudioClip clip;
    private void OnTriggerEnter(Collider other)
    {
        VoicePlayer p = other.gameObject.GetComponent<VoicePlayer>();
        if (p != null)
        {
            p.PlayLine(clip);
            Destroy(this.gameObject);
        }
    }
}
