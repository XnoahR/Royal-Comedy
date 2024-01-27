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
    void Start()
    {
        foreach(Button btn in buttons){
            btn.onClick.AddListener (()=> recordSkillButton(btn));
        }
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
      }
    }
}
