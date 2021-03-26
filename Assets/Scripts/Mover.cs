using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Rigidbody for our player
    Rigidbody rbody;

    // These variables change our movement speed - when using transform.Translate();
    // float xValue;
    // float yValue = 0f;
    // float zValue;

    float movementSpeed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
        rbody = GetComponent<Rigidbody>();
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

    // Receives Input from keyboard to register player movement
    void MovePlayer()
    {
        // Using transform.Translate() -> had issues when colliding with other objects
        // xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        // zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        // transform.Translate(xValue, yValue, zValue);

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rbody.AddForce(Vector3.forward * Time.deltaTime * movementSpeed);
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rbody.AddForce(Vector3.left * Time.deltaTime * movementSpeed);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rbody.AddForce(Vector3.back * Time.deltaTime * movementSpeed);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rbody.AddForce(Vector3.right * Time.deltaTime * movementSpeed);
        }
    }
}
