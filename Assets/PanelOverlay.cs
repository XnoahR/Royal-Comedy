using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class PanelOverlay : MonoBehaviour
{
    public TMP_Text overlayText;
    // Start is called before the first frame update
    void Start()
    {
        // switch(GameMaster.currentState){
        //     case GameState.WIN:
        //         overlayText.text = "You WIN!";
        //         break;
        //     case GameState.LOSE:
        //         overlayText.text = "You LOSE! :(";
        //         break;
        //     default:
        //         Debug.Log("This isn't supposed to happen");
        //         overlayText.text = "ERROR";
        //         break;
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
