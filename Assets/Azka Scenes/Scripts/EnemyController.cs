using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Transform target; // The player's transform (set in the Inspector)

    void Start()
    {
        // Set the target to the player's transform
        target = GameObject.FindGameObjectWithTag("hero").transform;

        // Disable the script initially (enabled by TurnController)
        enabled = false;
    }

    void Update()
    {
        // Check if the target (player) is within range
        if (Vector3.Distance(transform.position, target.position) < 2f)
        {
            // Perform some action when the player is within range (e.g., attack)
            AttackPlayer();
        }
        else
        {
            // Move towards the player
            MoveTowardsPlayer();
        }
    }

    void MoveTowardsPlayer()
    {
        // Calculate the direction to the player
        Vector3 direction = (target.position - transform.position).normalized;

        // Move towards the player
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    void AttackPlayer()
    {
        // Perform attack logic here
        Debug.Log("Enemy attacks the player!");

        // End the enemy's turn (you may want to notify the TurnController)
        //TurnController.Instance.EndEnemyTurn();
    }
}
