using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePlayer : MonoBehaviour
{
    public AudioSource source;

    
    public void PlayLine(AudioClip clip)
    {
        source.Stop();
        source.PlayOneShot(clip, 0.5f);
    }
}
