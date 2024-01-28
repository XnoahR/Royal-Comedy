using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Menu_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Set loop to true to enable video looping
        videoPlayer.isLooping = true;

        // Start video playback
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
