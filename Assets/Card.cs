using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int cardValue;
    //card image
    public Sprite cardImage;
    // Start is called before the first frame update

    public Card()
    {
        cardValue = Random.Range(1, 10);
        // cardImage = Resources.Load<Sprite>("card" + cardValue);
    }
    // void Start()
    // {
    //     cardValue = Random.Range(1, 10);
    //     // cardImage = Resources.Load<Sprite>("card" + cardValue);
    // }


    // Update is called once per frame
    void Update()
    {
        
    }

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
