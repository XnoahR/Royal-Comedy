using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{

    public GameObject hero;
    public GameObject enemy;

    private bool isPlayerTurn = true;
    // Start is called before the first frame update
    void Start()
    {
        StartPlayerTurn();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            SwitchTurn();
        }
        
    }

    void SwitchTurn()
    {
        if(isPlayerTurn)
        {
            EndPlayerTurn();
            StartEnemyTurn();
        }
        else
        {
            EndEnemyTurn();
            StartPlayerTurn();
        }
    }

    void StartPlayerTurn()
    {
        Debug.Log("Players turn");
        hero.GetComponent<PlayerScript>().enabled = true;
        enemy.GetComponent<EnemyController>().enabled = false;

        isPlayerTurn = true; 
    }

    void EndPlayerTurn()
    {
        hero.GetComponent<PlayerScript>().enabled = false;
    }

    void StartEnemyTurn()
    {
        Debug.Log("Enemy's turn");
        hero.GetComponent<PlayerScript>().enabled = false;
        enemy.GetComponent<EnemyController>().enabled = true;

        isPlayerTurn = false;

    }

    void EndEnemyTurn()
    {
        // Disable enemy AI control, hide UI, etc.
        enemy.GetComponent<EnemyController>().enabled = false;
    }
}
