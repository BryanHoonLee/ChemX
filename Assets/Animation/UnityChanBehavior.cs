using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanBehavior : MonoBehaviour
{
    public Animator unityChanAnimator;

    // Start is called before the first frame update
    void Start()
    {
        unityChanAnimator = GetComponent<Animator>();
    }

    public void PlayLose()
    {
        unityChanAnimator.Play("LOSE00", -1, 0f);
    }

    public void PlayWin()
    {
        unityChanAnimator.Play("WIN00", -1, 0f);
    }
}
