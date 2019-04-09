using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flask : MonoBehaviour
{
    private List<Element> elementList = new List<Element>();
    public Text elemList;

    // Start is called before the first frame update
    void Start()
    {
        elemList.text = "Elements: ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {  
        if (other.gameObject.CompareTag("Alkali Metal"))
        {
            UpdateElementList(other.name);
            elementList.Add(new Element("Alkali Metal", other.name, +1));
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Alkaline Earth Metal"))
        {
            UpdateElementList(other.name);
            elementList.Add(new Element("Alkali Earth Metal", other.name, +2));
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Nonmetal3"))
        {
            UpdateElementList(other.name);
            elementList.Add(new Element("Nonmetal", other.name, -3));
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Nonmetal4"))
        {
            UpdateElementList(other.name);
            elementList.Add(new Element("Nonmetal", other.name, -4));
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Nonmetal5"))
        {
            UpdateElementList(other.name);
            elementList.Add(new Element("Nonmetal", other.name, -5));
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Nonmetal6"))
        {
            UpdateElementList(other.name);
            elementList.Add(new Element("Nonmetal", other.name, -6));
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Halogen"))
        {
            UpdateElementList(other.name);
            elementList.Add(new Element("Halogen", other.name, -7));
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Noble Gas"))
        {
            UpdateElementList(other.name);
            elementList.Add(new Element("Noble Gas", other.name, 0));
            other.gameObject.SetActive(false);
        }
    }

    private void UpdateElementList(string elementName)
    {
        string[] temp = elementName.Split('(');
        if (elementList.Count == 0)
        {
            elemList.text += temp[0];
        }
        else
        {
            elemList.text += " + " + temp[0];
        }
    }

    private class Element
    {
        public string groupName;
        public string name;
        public int charge;

        public Element(string gn, string n, int c)
        {
            groupName = gn;
            name = n;
            charge = c;
        }
    }
}
