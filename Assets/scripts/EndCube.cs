using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCube : MonoBehaviour
{
    public float ClipTime = 20f;
    public float teleTime = 10f;

    public GameObject cube;
    public GameObject pipes;

    public Transform fallpos;
    public AudioClip clip; 
    public VoicePlayer vp;

    public bool playing = false;

    private void Start()
    {
        pipes.SetActive(false);
    }

    void FixedUpdate()
    {
        if (playing)
        {
            if (teleTime > 0)
            {
                teleTime -= Time.fixedDeltaTime;

                if (teleTime <= 0)
                {
                    Destroy(cube);
                }
            }           
           
            if (ClipTime > 0)
            {
                ClipTime -= Time.fixedDeltaTime;

                if (ClipTime <= 0)
                {
                    pipes.SetActive(true);
                    vp.gameObject.transform.position = fallpos.position;
                }
            }
        }
    }
    public void End()
    {
        if (!playing)
        {
            vp.PlayLine(clip);
            playing = true;
        }
    }
}
