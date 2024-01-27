using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillContainer : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Skills> skillObjects = new List<Skills>();
    public GameObject buttonPrefab;
    //Create function to manipulate buttons' text

    // Update is called once per frame
    void Start()
    {
        for(int i=0; i < skillObjects.Count; i++){
            _Setup_Buttons();
        }
    }

    void _Setup_Buttons(){

    }
}
