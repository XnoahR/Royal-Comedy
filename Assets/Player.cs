using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
      void Update()
    {
        // _Check_Card_Status();
        if(Input.GetKeyDown(KeyCode.Space)){
           //remove card
              _Generate_Card();
        }
        Debug.Log("Card Count: " + cards.Count);
        _Card_Count();
    }

    public void _Card_Clicked(Card card)
    {  
        //get the index of the card
       _Do_Comedy(card);
        // // cardPosition -= new Vector2(5, 0);
    }
}
