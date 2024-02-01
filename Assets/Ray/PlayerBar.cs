using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    // slider
    public GameObject slider;
    public Slider funBar;

    void Start()
    {
        Player = GameObject.Find("Player");   
        funBar = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //slider value based on player bar
        funBar.value = Player.GetComponent<Player>().funnyBar;
    }
}
