// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerCardUI : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public GameObject Player;
//     public Character characterScript;
//     public List<Card> cards;
//     //list of card values
//     public List<int> cardValues = new List<int>();
//     void Awake()
//     {
//         Player = GameObject.Find("Player");
//         characterScript = Player.GetComponent<Character>();
//         //reference to the card Lists
//         cards = characterScript.cards;
//         //get cardvalues from the cards
//     }
//     void Start(){
//         for(int i = 0; i < cards.Count; i++){
//             cardValues.Add(cards[i].cardValue);
//         }
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
