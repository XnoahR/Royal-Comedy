using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkillContainer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]  public  Button[] buttons = new Button[4];
    [Serialize] public static Skills[] skillObjects = new Skills[4];
    public Skills[] skillObjectInfo = new Skills[4];

    public static int selectedButtons;
    //Create function to manipulate buttons' text

    // Update is called once per frame
    void Awake()
    {
        foreach(Button btn in buttons){
            btn.onClick.AddListener (()=> recordSkillButton(btn));
        }
        
            skillObjects[0] = new AttackEffect();
            skillObjects[0].cooldown = 3;
            skillObjects[1] = new TurnManipulation();
            skillObjects[1].cooldown = 2;
            skillObjects[2] = new BarManipulation();
            skillObjects[2].cooldown = 3;
            skillObjects[3] = new CardManipulation();
            skillObjects[3].cooldown = 4;
        
    }

    void Update(){
        UpdateSkillCons();
    }

    void recordSkillButton(Button btn){
        selectedButtons = Array.IndexOf(buttons, btn);
        Debug.Log(selectedButtons);
    }

    void UpdateSkillCons(){
      for(int i = 0; i < skillObjectInfo.Length; i++){
        skillObjectInfo[i] = skillObjects[i];
        if (skillObjects[i] != null){
          buttons[i].GetComponent<SkillButton>().skill = skillObjects[i];
          buttons[i].GetComponent<SkillButton>()._Setup_Buttons();
        }
        // buttons[i].GetComponent<SkillButton>().skill = skillObjects[i]; 
        // buttons[i].GetComponent<SkillButton>()._Setup_Buttons();
      }
    }
}
