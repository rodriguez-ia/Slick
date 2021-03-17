using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // These variables change our movement speed
    float xValue;
    float yValue = 0f;
    float zValue;

    float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    // Print instructions at the start of the game
    void PrintInstructions()
    {
        Debug.Log("Welcome to Obstacle Course!");
        Debug.Log("Move the player, Slick, using the WASD keys or the arrow keys.");
        Debug.Log("Be careful not to hit the walls or any obstacles!!");
    }

    // Receives input from keyboard to register player movement
    void MovePlayer()
    {
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
