using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToFlask : MonoBehaviour
{
    public Transform flask;

    private float speed = 5;

    private bool startMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Equals))
        { 
            startMoving = true;
        }

        if (startMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, flask.position, speed * Time.deltaTime);
        }
    }
}
