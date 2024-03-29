using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnController : MonoBehaviour
{

    public GameObject hero;
    public GameObject enemy;
    public TextMeshProUGUI turnText;

    private bool isPlayerTurn = true;
    // Start is called before the first frame update
    void Start()
    {
        StartPlayerTurn();
        turnText.text = "Player's turn";
        StartCoroutine(RemoveTextAfterDelay(1f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SwitchTurn();
        }
    }

    void SwitchTurn()
    {
        if (isPlayerTurn)
        {
            StartCoroutine(EndPlayerTurn());
            Debug.Log("Player to enemy switch");
        }
        else
        {
            StartCoroutine(EndEnemyTurn());
            Debug.Log("Enemy to Player switch");

        }
    }

    void StartPlayerTurn()
    {
        Debug.Log("Player's turn");
        hero.GetComponent<PlayerScript>().enabled = true;

        isPlayerTurn = true;
    }

    IEnumerator EndPlayerTurn()
    {
        turnText.text = "Enemy's turn";
        hero.GetComponent<PlayerScript>().enabled = false;
        Debug.Log("Enemy's turn");

        yield return new WaitForSeconds(1f);

        turnText.text = "";
        StartEnemyTurn();
    }

    void StartEnemyTurn()
    {
        Debug.Log("Enemy's turn start");
        enemy.GetComponent<EnemyController>().enabled = true;

        isPlayerTurn = false;
        Debug.Log("Enemy's is movving or not");
    }

    IEnumerator EndEnemyTurn()
    {
        turnText.text = "Player's turn";
        enemy.GetComponent<EnemyController>().enabled = false;
        Debug.Log("Player's Turn");

        yield return new WaitForSeconds(1f);

        turnText.text = "";
        StartPlayerTurn();
    }

    IEnumerator RemoveTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        turnText.text = string.Empty;  // Set the text to an empty string to remove it
    }
}
