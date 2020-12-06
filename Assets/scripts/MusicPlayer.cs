using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource source;
    public AudioClip newclip;

    public float faderate = 0.1f;
    float vol;
    float current;

    delegate void currentAction();
    currentAction currentaction;

    void Start()
    {
        source = GetComponent<AudioSource>();
        vol = source.volume;
        currentaction = AllSet;
    }

    
    void FixedUpdate()
    {
        currentaction();
    }

    public void FadeIn()
    {
        if (source.volume <= vol)
        {
            source.volume += faderate;
        }
        else
        {
            source.volume = vol;
            currentaction = AllSet;
        }
    }
    public void FadeOut()
    {
        if (source.volume > 0)
        {
            source.volume -= faderate;
        }
        else
        {
            source.clip = newclip;
            currentaction = FadeIn;
        }
    }
    public void AllSet()
    {

    }
    public void ChangeClip(AudioClip clip)
    {
        newclip = clip;
        currentaction = FadeOut;
    }

}
