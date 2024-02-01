using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public static bool hasClicked = false;
    public Skills[] playerSkill = new Skills[4];
    public Skills selectedSkill = null;
    public GameObject skillContainer;
    void Start()
    {
        skillContainer = GameObject.Find("SkillContainer");
    }

    // Update is called once per frame
    void Update()
    {
        // _Check_Card_Status();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //remove card
            _Generate_Card();
            Debug.Log("Space pressed.");
        }
        // Debug.Log("Card Count: " + cards.Count);
        _Card_Count();
        if (selectedSkill != null) _Check_Selected_Skill();
    }

    public void _Card_Clicked(Card card)
    {
        //get the index of the card

        //stop if not player turn
        if (GameMaster.currentState != GameState.playerTurn) return;
        if (!hasClicked)
        {
            hasClicked = true;
            _Do_Comedy(card);
            StartCoroutine(gameMasterObject.PlayerTurn());
        }
        // // cardPosition -= new Vector2(5, 0);
    }

    private void _Check_Selected_Skill()
    {
        selectedSkill = SkillContainer.skillObjects[SkillContainer.selectedButtons];
        if (selectedSkill.isCooldown)
        {
            selectedSkill = null;
            Debug.Log("JAAAAAAANCOOOOOOOOOOOOOOOOOOOOOOOOOOOOK");
        }
    }

    public void _Clear_Selected_Skill()
    {
        selectedSkill = null;
    }

    public void _Select_Skill()
    {
        _Check_Selected_Skill();
    }

    // public void _Do_Comedy_Without_Card()
    // {
    //     if (selectedSkill == null) return;
    //     switch (selectedSkill.skillType)
    //     {

    //         // case SkillType.cardEffect:
    //         //     Debug.Log("Card Effect");
    //         //     break;
    //         default:
    //             Debug.Log("No Skill Selected or Skill Type need a card");
    //             break;
    //     }
    // }

    void set_cooldown()
    {
        SkillContainer.skillObjects[SkillContainer.selectedButtons].isCooldown = true;
        SkillContainer.skillObjects[SkillContainer.selectedButtons].cooldownDiff = SkillContainer.skillObjects[SkillContainer.selectedButtons].cooldown;
    }

    public void _Do_Comedy(Card card)
    {
        if (selectedSkill == null)
        {
            if (card == null) return;
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
        if (selectedSkill != null)
        {
            switch (selectedSkill.skillType)
            {
                case SkillType.attackEffect:
                    if (card == null) return;
                    // Check index
                    Debug.Log("Card Clicked : " + card.gameObject.name + " from index : " + cards.IndexOf(card));

                    //remove the card from the list
                    cards.Remove(card);
                    //remove the card value from the list
                    cardValues.Remove(card.cardValue);
                    Debug.Log("Card Count: " + cards.Count);
                    // // //Do damge to the character
                    fillBar(card.cardValue * selectedSkill.skillValue);
                    // // //destroy the card
                    Destroy(card.gameObject);
                    set_cooldown();
                    break;
                case SkillType.cardEffect:
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
                    Debug.Log("Card Effect");
                    _Generate_Card();
                    set_cooldown();
                    break;
                case SkillType.turnEffect:
                    if (card == null) return;
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
                    GameMaster.skipTurns = true;
                    set_cooldown();
                    selectedSkill = null;
                    break;
                case SkillType.barEffect:
                    //get Enemy
                    GameObject enemy2 = GameObject.Find("Enemy");
                    //get Enemy Script
                    Enemy enemyScript2 = enemy2.GetComponent<Enemy>();
                    //get Enemy Bar
                    enemyScript2.funnyBar -= selectedSkill.skillValue;
                    set_cooldown();
                    StartCoroutine(gameMasterObject.PlayerTurn());
                    break;
                    // default:
                    //     Debug.Log("No Skill Selected");
                    //     break;
            }
            // case se
        }

    }
}
