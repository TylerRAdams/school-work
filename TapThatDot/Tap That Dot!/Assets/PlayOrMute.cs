using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOrMute : MonoBehaviour
{
    AudioSource audioSource;
    TxtHandler Reader;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Reader = new TxtHandler();
    }

    private void Update()
    {
        if (Reader.getIsMuted() == 1)
        {
            audioSource.mute = true;

        }else if (Reader.getIsMuted() == 0) { audioSource.mute = false; }
    }

}
