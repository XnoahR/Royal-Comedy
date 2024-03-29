using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public abstract class ButtonParent : MonoBehaviour
{
    public Button button;
    public Skills skill;
    private SkillContainer skillContainer;
    public TMP_Text valText;
    public TMP_Text typeText;
    public TMP_Text cdText;

    // Update is called once per frame
    public void _Setup_Buttons(){
        Sprite skillSprite = Resources.Load<Sprite>("Skills/"+ skill.skillType.ToString());
        if (skillSprite != null){
            button.GetComponent<Button>().GetComponent<Image>().sprite = skillSprite;
        }
        // Debug.Log(skillSprite);
        // if (skill != null){
        //     valText.text = skill.skillValue.ToString();
        //     cdText.text = skill.cooldown.ToString();
        //     typeText.text = skill.skillType.ToString();
        //     if (skillSprite != null){
        //         button.GetComponent<Button>().GetComponent<Image>().sprite = skillSprite;
        //     }
        }
        // switch (skill.skillType){
        //     case SkillType.turnEffect:
        //         typeText.text = "Turn";
        //         break;
        //     case SkillType.barEffect:
        //         typeText.text = "Bar";
        //         break;
        //     case SkillType.attackEffect:
        //         typeText.text = "Attack";
        //         break;
        //     case SkillType.cardEffect:
        //         typeText.text = "Card";
        //         break;
        // }
    }

