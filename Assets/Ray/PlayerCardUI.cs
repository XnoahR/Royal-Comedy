using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public Player playerScript;
    public List<Card> cards;
    //list of card values
    public List<int> cardValues;
    //get card prefabs
    public GameObject cardPrefab;
    [SerializeField] private int previousCardCount;
    [SerializeField] private int cardCount;

    private bool isDrawCard = false;
    void Awake()
    {
        Player = GameObject.Find("Player");

    }
    void Start(){
        playerScript = Player.GetComponent<Player>();
        _Print_Card();
}


    // Update is called once per frame
    void Update()
    {
        _Check_Card();
        if(Player.GetComponent<Player>().addingCard){
            Player.GetComponent<Player>().addingCard = false;
            _Print_Single_Card();
        }   
        // _Check_Card_Count();
        // if(isDrawCard) _Generate_Card();   
    }

    void _Print_Single_Card(){
        //print single card from last index
        //get the card list from the character script
        cards = playerScript.cards;
        //get the card values from the character script
        cardValues = playerScript.cardValues;
        //get the last index of the card list
        int lastIndex = cards.Count - 1;
        //instantiate the card prefab
        GameObject cardObject = Instantiate(cardPrefab, transform);
        Player.GetComponent<Player>().cards[lastIndex] = cardObject.GetComponent<Card>();
        //give the name to the card unique random name
        cardObject.name = "Card " + Random.Range(1, 10000);
        //get the card script
        Card cardScript = cardObject.GetComponent<Card>();
        //set the card value
        cardScript.cardValue = cardValues[lastIndex];
        //set the card image
    }

    //Instantiate the cards based on the list of card that connected to the character script
     void _Print_Card(){
        //get the card list from the character script
        cards = playerScript.cards;
        //get the card values from the character script
        cardValues = playerScript.cardValues;
        //instantiate the cards based on the list of card and give the name to the card
        for(int i = 0; i < cards.Count; i++){
            GameObject cardObject = Instantiate(cardPrefab, transform);
            Player.GetComponent<Player>().cards[i] = cardObject.GetComponent<Card>();
            //give the name to the card
            cardObject.name = "Card " + i;
            //get the card script
            Card cardScript = cardObject.GetComponent<Card>();
            //set the card value
            cardScript.cardValue = cardValues[i];
            //set the card image
            //check if the card with the same name is exist. If exist then skip the instantiate
            if(GameObject.Find("Card " + i) != null) continue;
            //instantiate the card prefab
            //set the card position
        }
            Debug.Log("SPAWNED!"); 
     }

    // void _Check_Card_Count(){
    //    if (cards.Count != previousCardCount)
    //     {
    //         isDrawCard = true;
    //         _Generate_Card();
    //         // Update the previousCardCount
    //         previousCardCount = cardCount;
    //     }
    // }

    // void _Generate_Card(){
    //     //Instantiate the cards based on the list of card
    //      foreach (Card card in cards){
    //         //instantiate the card prefab
    //         GameObject cardObject = Instantiate(cardPrefab, transform);
            
    //      }
    //     isDrawCard = false;
    // }

    void _Check_Card(){
        cards = playerScript.cards;
        cardValues = playerScript.cardValues;
        cardCount = cards.Count;
    }
}
