using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScientistBehavior : MonoBehaviour
{
    public Animator scientistAnimator;

    // Start is called before the first frame update
    void Start()
    {
        scientistAnimator = GetComponent<Animator>();
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
