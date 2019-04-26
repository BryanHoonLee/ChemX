using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScientistAnimationTest : MonoBehaviour
{
    public Animator scientistAnimator;
    float timer; //20 Seconds before activation of idle animation

    // Start is called before the first frame update
    void Start()
    {
        scientistAnimator = GetComponent<Animator>();

        timer = 0;
        
    }
    // Update is called once per frame
    void Update()
    {
        UpdateTime();

        if(Input.GetKeyDown("a"))
        {
            scientistAnimator.Play("LOSE00", -1, 0f);
        }
        else if(Input.GetKeyDown("b"))
        {
            scientistAnimator.Play("WIN00", -1, 0f);
        }
        if (timer >= 10 || Input.GetKeyDown("c"))
        {
            int random = Random.Range(1, 4);
            scientistAnimator.Play("Idle_" + random, -1, 0f);
            timer = 0;
            Debug.Log("playing Idle_" + random);
        }

        Debug.Log("time: " + timer);
    }

    public void UpdateTime()
    {
        timer += Time.deltaTime;
    }

}
