using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Attack Manipulation Skill", menuName = "Skills/Attack Manipulation Skill")]

public class AttackEffect : Skills
{

    public Player player;
    public void Awake(){
        skillType = SkillType.attackEffect;
    }

    void Start(){
    }

    public override void DoCard(Card card){
        player = GameObject.Find("Player").GetComponent<Player>();
        Debug.Log("Cerdas");
        //  if(card == null) return;
        
        // // Check index
        // Debug.Log("Card Clicked : " + card.gameObject.name + " from index : " + player.cards.IndexOf(card));

        // //remove the card from the list
        // player.fillBar(card.cardValue*2);
        // player.cards.Remove(card);
        // //remove the card value from the list
        // player.cardValues.Remove(card.cardValue);
        // Debug.Log("Card Count: " + player.cards.Count);
        // // // //Do damge to the character
        // // // //destroy the card
        // Destroy(card.gameObject);

        // if(!isCooldown){
        //     Debug.Log("Increase attak");
        // }
        // else{
        //     Debug.Log("Cooldown cuy");
        // }
    }
}
