using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Attack Manipulation Skill", menuName = "Skills/Attack Manipulation Skill")]

public class AttackEffect : Skills
{
    public void Awake(){
        skillType = SkillType.attackEffect;
    }

    public override void Activate(){
        if(!isCooldown){
            float finalValue = 0;
            switch (skillOperation){
                case SkillOperation.increase:
                    finalValue = skillValue;
                    break;
                case SkillOperation.decrease:
                    finalValue = -(skillValue);
                    break;
                case SkillOperation.multiply:
                    finalValue = Player.selectedCard.cardValue * (skillValue - 1);
                    break;
                case SkillOperation.divide:
                    finalValue = -(Player.selectedCard.cardValue/skillValue);
                    break;
            }
            isCooldown = true;
            Player.selectedCard.cardValue += (int)finalValue;
        }
        else{
            Debug.Log("Cooldown cuy");
        }
    }
}
