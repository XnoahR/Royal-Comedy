using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public int cardValue;
    public Button cardButton;
    public GameObject Character;
    //card image
    public Sprite cardBackImage;
    Sprite sp;
    // Start is called before the first frame update

        public Card(int cardValue)
    {

        this.cardValue = cardValue;
    }

    void Start()
    {
        cardButton = GetComponent<Button>();

        Character = GameObject.Find("Player");
        cardButton.onClick.RemoveAllListeners();
        cardButton.onClick.AddListener(() => Character.GetComponent<Player>()._Card_Clicked(GetComponent<Card>()));
        sp = Resources.Load<Sprite>("Cards/" + cardValue);
        cardButton.GetComponent<Image>().sprite = sp;
        // cardButton.onClick.AddListener(_Do_Damage);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.eulerAngles.y < 90 || transform.rotation.eulerAngles.y > 270 ) cardButton.GetComponent<Image>().sprite = sp;
        else cardButton.GetComponent<Image>().sprite = cardBackImage;
    }


    public void _Do_Damage(int cardValue)
    {
        //get the character
        GameObject character = GameObject.Find("Player");
        //get the character script
        Character characterScript = character.GetComponent<Character>();
        //subtract the card value from the funny bar
        characterScript.funnyBar -= cardValue;
        //destroy the card
        
    }

    public IEnumerator RotateCard(float startValue, float targetValue, float moveTime)
    {
        float elapsed_time = 0;

        while (elapsed_time < moveTime)
        {
            float t = elapsed_time / moveTime;

            // Apply ease-out quadratic function
            t = 1 - Mathf.Pow(1 - t, 2);

            // Calculate the current value using linear interpolation
            float currentValue = Mathf.Lerp(startValue, targetValue, t);
            transform.rotation = Quaternion.Euler(0, currentValue, 0);

            // Update your object or do something with the currentValue
            // Debug.Log(currentValue);

            // Increment elapsed_time in each frame
            elapsed_time += Time.deltaTime;

            yield return null;
        }

        // Reset startValue for the next run
        startValue = 0;

        yield return null;
        
        Destroy(gameObject);
    }
}
