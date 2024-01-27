using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;
    // slider
    public GameObject slider;
    public Slider funBar;

    void Start()
    {
        Enemy = GameObject.Find("Enemy");   
        funBar = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //slider value based on Enemy bar
        funBar.value = Enemy.GetComponent<Enemy>().funnyBar;
    }
}
