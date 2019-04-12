using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScientistAnimationTest : MonoBehaviour
{
    public Animator scientistAnimator;

    // Start is called before the first frame update
    void Start()
    {
        scientistAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("a"))
        {
            scientistAnimator.Play("LOSE00", -1, 0f);
        }
        else if(Input.GetKeyDown("b"))
        {
            scientistAnimator.Play("WIN00", -1, 0f);
        }
    }
}
