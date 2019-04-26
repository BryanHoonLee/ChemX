using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScientistBehavior : MonoBehaviour
{
    public Animator scientistAnimator;
    float timer; 

    const float IDLE_TIME = 20; //20 Seconds before activation of idle animation

    // Start is called before the first frame update
    void Start()
    {
        scientistAnimator = GetComponent<Animator>();

        timer = 0;
        
    }

    void Update()
    {
        if(IsIdle())
        {
            UpdateTime();
        }
        if(timer >= IDLE_TIME && IsIdle())
        {
            int random = Random.Range(1, 4);
            scientistAnimator.Play("Idle_" + random, -1, 0f);
            timer = 0;
        }
    }

    public void UpdateTime()
    {
        timer += Time.deltaTime;
    }

    bool IsIdle()
    {
        return this.scientistAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle");
    }

    public void PlayLose()
    {
        scientistAnimator.Play("LOSE00", -1, 0f);
    }

    public void PlayWin()
    {
        scientistAnimator.Play("WIN00", -1, 0f);
    }
}
