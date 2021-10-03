using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Sound : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio.loop = true;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
