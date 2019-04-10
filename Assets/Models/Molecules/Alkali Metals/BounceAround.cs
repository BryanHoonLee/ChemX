using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceAround : MonoBehaviour
{
    public Transform Flask;

    private float moveSpeed = 1000;
    private Rigidbody rBody;
    private bool motionSet;
    private float moveX, moveY, moveZ;

    // Start is called before the first frame update
    void Start()
    {
        motionSet = false;
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == Flask.position)
        {
            float[] speed = { 0.25f, 0.5f, 0.75f, 1.0f };
            var rand = new System.Random();
            int index = rand.Next(speed.Length);
            float randSpeed = speed[index];
            moveX = (float)randSpeed * moveSpeed * Time.deltaTime;
            moveY = (float)randSpeed * moveSpeed * Time.deltaTime;
            moveZ = (float)randSpeed * moveSpeed * Time.deltaTime;
            motionSet = true;
        }
        if (motionSet)
        {
            rBody.AddForce(moveX, moveY, moveZ);
        }
    }
}
