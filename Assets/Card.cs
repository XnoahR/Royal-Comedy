using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public int cardValue;
    public Button cardButton;
    public GameObject Character;
    //card image
    public Sprite cardImage;
    // Start is called before the first frame update

        public Card(int cardValue)
    {
        //  cardButton = GetComponent<Button>();
        //  cardButton.onClick.AddListener(_On_Click);
        this.cardValue = cardValue;
    }

    // void InitializeCard()
    // {

    //     cardValue = Random.Range(1, 10);
    // }
    // void Start()
    // {
    //     cardValue = Random.Range(1, 10);
    //     // cardImage = Resources.Load<Sprite>("card" + cardValue);
    // }

    void Start()
    {
        cardButton = GetComponent<Button>();
       Character = GameObject.Find("Player");
         cardButton.onClick.AddListener(() => Character.GetComponent<Player>()._Card_Clicked(GetComponent<Card>()));
        // cardButton.onClick.AddListener(_Do_Damage);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //get on click event
    // public void _On_Click()
    // {
    //     //get the character
    //     GameObject character = GameObject.Find("Player");
    //     //get the character script
    //     Character characterScript = character.GetComponent<Character>();
    //     //subtract the card value from the funny bar
    //     characterScript.funnyBar -= cardValue;
    //     //destroy the card
    //     Destroy(gameObject);
    // }

    public void _Do_Damage(int cardValue)
    {
        //get the character
        GameObject character = GameObject.Find("Player");
        //get the character script
        Character characterScript = character.GetComponent<Character>();
        //subtract the card value from the funny bar
        characterScript.funnyBar -= cardValue;
        //destroy the card
        
    }
}
