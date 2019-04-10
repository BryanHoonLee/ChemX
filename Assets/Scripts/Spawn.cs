using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Molecule;
    public string key;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (key == "Q" && Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Non Metal 3 Spawned");
        }
        if (key == "W" && Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Non Metal 4 Spawned");
        }
        if (key == "E" && Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Non Metal 5 Spawned");
        }
        if (key == "R" && Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Non Metal 6 Spawned");
        }
        if (key == "O" && Input.GetKeyDown(KeyCode.O))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Halogen Spawned");
        }
        if (key == "P" && Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Noble Gas Spawned");
        }
        if (key == "A" && Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Alkali Metal Spawned");
        }
        if (key == "S" && Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Alkali Earth Metal Spawned");
        }
        if (key == "J" && Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Other Metal Spawned");
        }
        if (key == "T" && Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(Molecule, transform.position, transform.rotation);
            print("Transition Metal Spawned");
        }
    }
}
