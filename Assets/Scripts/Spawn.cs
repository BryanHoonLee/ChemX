using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Element;
    public string key;
    public string name;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        if (key == "Q" && Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(Element, transform.position, transform.rotation);
            print("Non Metal 3 Spawned");
        }
        if (key == "W" && Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(Element, transform.position, transform.rotation);
            print("Non Metal 4 Spawned");
        }
        if (key == "E" && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Element, transform.position, transform.rotation);
            print("Non Metal 5 Spawned");
        }
        if (key == "R" && Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(Element, transform.position, transform.rotation);
            print("Non Metal 6 Spawned");
        }
        if (key == "O" && Input.GetKeyDown(KeyCode.O))
        {
            Instantiate(Element, transform.position, transform.rotation);
            print("Halogen Spawned");
        }
        if (key == "P" && Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(Element, transform.position, transform.rotation);
            print("Noble Gas Spawned");
        }
        if (Input.GetButtonDown("A"))
        {
            if (key == "A1" && Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Li Spawned");
                print("Alkali Metal Spawned");
            }

        }
        if (key == "S" && Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(Element, transform.position, transform.rotation);
            print("Alkali Earth Metal Spawned");
        }
        if (key == "J" && Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(Element, transform.position, transform.rotation);
            print("Other Metal Spawned");
        }
        if (key == "T" && Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(Element, transform.position, transform.rotation);
            print("Transition Metal Spawned");
        }
    }
}
