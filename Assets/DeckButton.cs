using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class DeckButton : ButtonParent
{
    //public GameObject skillContainerObject = GameObject.Find("SkillContainer");
    public GameObject skillContainerObject;

    // Start is called before the first frame update
    void Start(){
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(onClick);
        _Setup_Buttons();
    }
    void onClick(){
        Debug.Log("Clicked");
        if (!SkillContainer.skillObjects.Contains(skill)){
            SkillContainer.skillObjects[SkillContainer.selectedButtons] = skill;
            Debug.Log(SkillContainer.skillObjects[SkillContainer.selectedButtons]);
        }
        else{
            Debug.Log("dah ada");
        }
        // for (int i=0; i < SkillContainer.skillObjects.Length; i++){
        //     if (SkillContainer.skillObjects[i] == null)
        //     {
        //         if (!SkillContainer.skillObjects.Contains(skill)){
        //             SkillContainer.skillObjects[i] = skill;
        //             break;
        //         }
        //         else{
        //             Debug.Log("KONTOL DAH ADA");
        //             break;
        //         }
        //     }
        // }
    }
}
