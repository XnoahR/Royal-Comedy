using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public int funnyBar = 100;
    //Reference to cards
    public Card playerCard;
    public List<Card> cards;
    public List<int> cardValues = new List<int>();
    
    void Start()
    {
        //add 3 values to the list
        for(int i = 0; i < 3; i++){
            playerCard = new Card();
            cards.Add(playerCard);
            cardValues.Add(playerCard.cardValue);
            //show card value
            Debug.Log(cards[i].cardValue);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
           if(cards.Count < 5){
               _Generate_Card();
           }
           else{
                Debug.Log("You have too many cards");
           }
        }
    }

    void _Generate_Card(){
        //add a new card to the list
        playerCard = new Card();
        cards.Add(playerCard);
        cardValues.Add(playerCard.cardValue);
    }
}
