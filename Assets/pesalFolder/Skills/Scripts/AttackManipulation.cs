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
            Debug.Log("Increase attak");
        }
        else{
            Debug.Log("Cooldown cuy");
        }
    }
}
