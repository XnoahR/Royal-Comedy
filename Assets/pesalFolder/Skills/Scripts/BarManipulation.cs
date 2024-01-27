using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bar Manipulation Skill", menuName = "Skills/Bar Manipulation Skill")]

public class BarManipulation : Skills
{
    public void Awake(){
        skillType = SkillType.barEffect;
    }
    
    public override void Activate(){
        if (!isCooldown){
            Debug.Log("Manipulate BAR!!!");
        }
        else{
            Debug.Log("Cooldown coy");
        }
    }
}
