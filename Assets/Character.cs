using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public int funnyBar;
    private int DEFAULT_FUNNY_BAR = 0;
    private int MAX_FUNNY_BAR = 100;
    //Reference to cards
    public Card playerCard;
    public List<Card> cards;
    public List<int> cardValues = new List<int>();
    int cardCounter;
    public bool addingCard = false;
    void Awake()
    {
        //add 3 values to the list
        for(int i = 0; i < 3; i++){
            
        Card newCard = new Card(Random.Range(1, 10));
        
        // Add the new card to the list
        cards.Add(newCard);
        
        // Add the card value to the cardValues list
        cardValues.Add(newCard.cardValue);
        
        // Optionally, you can also log the generated card value
        Debug.Log("Generated Card Value: " + newCard.cardValue + " Card Count: " + cards.Count);
            //show card value
            Debug.Log(cards[i].cardValue);
        }
        funnyBar = DEFAULT_FUNNY_BAR;
        
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

    public void _Generate_Card(){
        //add a new card to the list
       // Create a new card
       
        Card newCard = new Card(Random.Range(1, 10));
        
        // Add the new card to the list
        cards.Add(newCard);
        
        // Add the card value to the cardValues list
        cardValues.Add(newCard.cardValue);
        
        // Optionally, you can also log the generated card value
        Debug.Log("Generated Card Value: " + newCard.cardValue + " Card Count: " + cards.Count);
        addingCard = true;
    }

    protected void _Card_Count(){
        cardCounter = cards.Count;
    }

    public void _Do_Comedy(Card card){
        if(card == null) return;
        // Check index
        Debug.Log("Card Clicked : " + card.gameObject.name + " from index : " + cards.IndexOf(card));

        //remove the card from the list
        cards.Remove(card);
        //remove the card value from the list
        cardValues.Remove(card.cardValue);
        Debug.Log("Card Count: " + cards.Count);
        // // //Do damge to the character
        fillBar(card.cardValue);
        // // //destroy the card
        Destroy(card.gameObject);
    }

    public void _Use_Skill(){}
    // public void _Card_Clicked(Card card)
    // {  
    //     //get the index of the card
    //    _Do_Comedy(card);
    //     // // cardPosition -= new Vector2(5, 0);
    // }

    private void fillBar(int val){
        this.funnyBar += val;
    }
}
