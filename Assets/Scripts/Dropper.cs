using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeUntilDrop = 2.0f;
    MeshRenderer mRenderer;
    Rigidbody rbody;
    bool isDropped = false;

    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        rbody = GetComponent<Rigidbody>();

        mRenderer.enabled = false;
        rbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDropped == false && Time.timeSinceLevelLoad > timeUntilDrop)
        {
            mRenderer.enabled = true;
            rbody.useGravity = true;
            isDropped = true;
        }
    }
}
