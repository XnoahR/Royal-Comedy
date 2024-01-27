using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Get input from the player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        // Move the cube
        MoveCube(moveDirection);
    }

    void MoveCube(Vector3 moveDirection)
    {
        // Translate the cube based on the input and speed
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
