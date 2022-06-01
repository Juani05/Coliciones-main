using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playsound : MonoBehaviour
{
    public AudioClip playersound;
    public AudioClip playerdied;
    AudioSource fuenteaudio;

    // Start is called before the first frame update
    void Start()
    {
        fuenteaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            fuenteaudio.clip = playersound;
            fuenteaudio.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            fuenteaudio.clip = playersound;
            fuenteaudio.Play();
        }
    }
}
