using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkillType{
    turnEffect,
    attackEffect,
    barEffect,
    cardEffect
}

public enum SkillOperation{
    increase,
    decrease,
    multiply,
    divide
}

public abstract class Skills : ScriptableObject
{
    public int skillValue;
    public SkillType skillType;
    public SkillOperation skillOperation;
    public GameObject prefab;
    [TextArea(10, 20)]
    public string description;
    public int cooldown;
    public bool isCooldown = false;
    public int cooldownDiff;
    public virtual void Activate(){}
    public void checkCooldown(){
        int currentTurn = GameMaster.playerPace;
        if (currentTurn - cooldown < cooldownDiff){
            return;
        }
        else{
            isCooldown = false;
        }
    }
}
