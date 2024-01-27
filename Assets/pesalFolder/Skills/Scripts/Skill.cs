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
    public float cooldown;
    protected bool isCooldown = false;
    public virtual void Activate(){}
}
