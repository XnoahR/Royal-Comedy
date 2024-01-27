// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Cards : MonoBehaviour
// {
//     // Start is called before the first frame update
    
//     //List of cards
//     public List<Card> cards = new List<Card>();
//     // public GameObject cardPrefab;
//     public Card card;
//     [SerializeField] private Vector2 cardPosition;
//     void Start()
//     {
//         //add 3 values to the list
//         for(int i = 0; i < 3; i++){
//             card = new Card();
//             cards.Add(card);
//         }
//     }

//     //Card constructor
    

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             _Generate_Card();
//         }
//         if (Input.GetKeyDown(KeyCode.X))
//         {
//             _Card_Clicked(cards[0].gameObject);
//         }
        
//     }

//     public void _Generate_Card(){
//         //add a new card to the list
//         card = new Card();
//         cards.Add(card);
//     }

//     public void _Card_Clicked(GameObject card)
//     {
//         //remove the card from the list
//         cards.Remove(card.GetComponent<Card>());
//         //Do damge to the character
//         card.GetComponent<Card>()._Do_Damage(card.GetComponent<Card>().cardValue);
//         //destroy the card
//         Destroy(card);
//         // cardPosition -= new Vector2(5, 0);
//     }
// }
