using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    // Count the number of times the player has bumped into an object
    private void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("You have bumped into an object " + hits + " times.");
    }
}
