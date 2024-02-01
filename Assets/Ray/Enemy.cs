using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public static bool hasMoved = true;
    void Update()
    {
         // _Check_Card_Status();
        if (!hasMoved){
            _Generate_Card();
            StartCoroutine(_Random_Pick_Coroutine());
            }
            // Debug.Log("Enemy Card Count: " + cards.Count);
            _Card_Count();
            hasMoved = true;
    }

    //coroutine 
    IEnumerator _Random_Pick_Coroutine(){
        //wait for 2 seconds
        int randomCard = Random.Range(1, cards.Count);
        Debug.Log("Randoming Card...");
        yield return new WaitForSeconds(2.0f);
        if(cards.Count == 1) _Do_Comedy(cards[0]);
        else _Do_Comedy(cards[randomCard-1]);
        StartCoroutine(gameMasterObject.EnemyTurn());

        Debug.Log("Random Card: " + cards[randomCard-1].cardValue + " Card Count: " + cards.Count);
    }
}
