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
            GameObject enemy2 = GameObject.Find("Enemy");
            //get Enemy Script
            Enemy enemyScript2 = enemy2.GetComponent<Enemy>();
            //get Enemy Bar
            enemyScript2.funnyBar -= skillValue;
        }
        else{
            Debug.Log("Cooldown coy");
        }
    }
}
