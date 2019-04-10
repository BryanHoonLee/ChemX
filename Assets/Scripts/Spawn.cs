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
        // Alkali Metals
        if (Input.GetKey(KeyCode.A))
        {
            // Li
            if (key == "A1" && Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Li Spawned");
            }
            // K
            if (key == "A2" && Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("K Spawned");
            }
            // Na
            if (key == "A3" && Input.GetKeyDown(KeyCode.Alpha3))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Na Spawned");
            }
            // Rb
            if (key == "A4" && Input.GetKeyDown(KeyCode.Alpha4))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Rb Spawned");
            }
            // Cs
            if (key == "A5" && Input.GetKeyDown(KeyCode.Alpha5))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Cs Spawned");
            }
            // Fr
            if (key == "A6" && Input.GetKeyDown(KeyCode.Alpha6))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Fr Spawned");
            }
        }
        // Alkaline Earth Metals
        if (Input.GetKey(KeyCode.S))
        {
            // Be
            if (key == "S1" && Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Be Spawned");
            }
            // Mg
            if (key == "S2" && Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Mg Spawned");
            }
            // Ca
            if (key == "S3" && Input.GetKeyDown(KeyCode.Alpha3))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Ca Spawned");
            }
            // Sr
            if (key == "S4" && Input.GetKeyDown(KeyCode.Alpha4))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Sr Spawned");
            }
            // Ba
            if (key == "S5" && Input.GetKeyDown(KeyCode.Alpha5))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Ba Spawned");
            }
            // Ra
            if (key == "S6" && Input.GetKeyDown(KeyCode.Alpha6))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Ra Spawned");
            }
        }
        // NonMetal 3
        if (Input.GetKey(KeyCode.Q))
        {
            // B
            if (key == "Q1" && Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("B Spawned");
            }
        }
        // NonMetal 4
        if (Input.GetKey(KeyCode.W))
        {
            // C
            if (key == "W1" && Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("C Spawned");
            }
            // Ge
            if (key == "W2" && Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Ge Spawned");
            }
            // Si
            if (key == "W3" && Input.GetKeyDown(KeyCode.Alpha3))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Si Spawned");
            }
        }
        // NonMetal 5
        if (Input.GetKey(KeyCode.E))
        {
            // N
            if (key == "E1" && Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("N Spawned");
            }
            // As
            if (key == "E2" && Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("As Spawned");
            }
            // P
            if (key == "E3" && Input.GetKeyDown(KeyCode.Alpha3))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("P Spawned");
            }
            // Sb
            if (key == "E4" && Input.GetKeyDown(KeyCode.Alpha4))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Sb Spawned");
            }
        }
        // NonMetal 6
        if (Input.GetKey(KeyCode.R))
        {
            // O
            if (key == "R1" && Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("O Spawned");
            }
            // S
            if (key == "R2" && Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("S Spawned");
            }
            // Se
            if (key == "R3" && Input.GetKeyDown(KeyCode.Alpha3))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Se Spawned");
            }
            // Te
            if (key == "R4" && Input.GetKeyDown(KeyCode.Alpha4))
            {
                Instantiate(Element, transform.position, transform.rotation);
                print("Te Spawned");
            }
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
