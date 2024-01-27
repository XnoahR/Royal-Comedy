using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Manipulation Skill", menuName = "Skills/Card Manipulation Skill")]

public class CardManipulation : Skills
{
    public void Awake(){
        skillType = SkillType.cardEffect;
    }
    
    public override void Activate(){
        if (!isCooldown){
            Debug.Log("Manipulate CARD DRAW!!!");
        }
        else{
            Debug.Log("Cooldown coy");
        }
    }
}
