using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnH : MonoBehaviour
{

    public Object ElementToSpawn;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown("q"))
        {
            Instantiate(ElementToSpawn, transform.position, transform.rotation);
            print("Hydrogen was spawned.");
        }
    }
}
