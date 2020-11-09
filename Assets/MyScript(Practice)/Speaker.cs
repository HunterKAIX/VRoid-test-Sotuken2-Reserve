using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : MonoBehaviour
{
    AudioSource sound;
    public AudioClip clipSound;

    // Start is called before the first frame update
    void Start()
    {

        sound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ComparisonSpeaker()
    {

        sound.PlayOneShot(clipSound);

    }
}
