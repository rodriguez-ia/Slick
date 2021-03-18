using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xValue = 0.00f;
    [SerializeField] float yValue = 0.75f;
    [SerializeField] float zValue = 0.00f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
