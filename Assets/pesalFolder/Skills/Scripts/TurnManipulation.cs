using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Turn Manipulation Skill", menuName = "Skills/Turn Manipulation Skill")]

public class TurnManipulation : Skills
{
    public void Awake(){
        skillType = SkillType.turnEffect;
    }
    
    public override void Activate(){
        if (!isCooldown){
            GameMaster.skipTurns = true;
            isCooldown = true;
        }
        else{
            //checkCooldown();
        }
    }
}
