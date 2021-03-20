using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    // Count the number of times the player has bumped into an object
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You have bumped into an object " + hits + " times.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hits > 5)
         {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         }
    }
}