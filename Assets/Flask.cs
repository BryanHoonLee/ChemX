using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flask : MonoBehaviour
{  
    public bool isFinished;
    public Text elemList;
    public Text questionText;
    public Text resultText;

    private QnA prompt;
    private List<Element> elementList = new List<Element>();

    // Start is called before the first frame update
    void Start()
    {
        prompt = GenerateQnA();
        questionText.text = "Create\n  " + prompt.question;
        isFinished = false;
        elemList.text = "Elements: ";
        resultText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            isFinished = true;
            if (CheckAnswer())
            {
                resultText.text = "You Win!";
            }
            else
            {
                resultText.text = "You Lose.";
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isFinished)
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
    }

    private bool CheckAnswer()
    {
        List<string> answer = new List<string>();
        string[] temp = prompt.answer.Split(',');

        // If More Elements than Answer
        if (answer.Count == 0 && elementList.Count > 0)
        {
            return false;
        }
        // If Less Elements than Answer
        if (answer.Count > 0 && elementList.Count == 0)
        {
            return false;
        }

        foreach (string s in temp)
        {
            answer.Add(s);
        }

        for (int i = 0; i < elementList.Count; i++)
        {
            if (answer.Contains(elementList[i].name))
            {
                answer.Remove(elementList[i].name);
                elementList.RemoveAt(i);
                i--;

                // Contains Incorrect Element
                if (answer.Count == 0 && elementList.Count > 0)
                {
                    return false;
                }
                // Not Enough of a Specific Element
                if (answer.Count > 0 && elementList.Count == 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return true;
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

    private QnA GenerateQnA()
    {
        List<QnA> qna = new List<QnA>();
        qna.Add(new QnA { question = "NaCl", answer="Na,Cl" });
        qna.Add(new QnA { question = "2NaCl", answer = "Na,Na,Cl,Cl" });
        qna.Add(new QnA { question = "Li3N", answer = "Li,Li,Li,N" });
        qna.Add(new QnA { question = "3KCl", answer = "K,K,K,Cl,Cl,Cl" });
        qna.Add(new QnA { question = "Li3N", answer = "Li,Li,Li,N" });
        qna.Add(new QnA { question = "BeO", answer = "Be,O" });
        qna.Add(new QnA { question = "Mg2C", answer = "Mg,Mg,C" });
        qna.Add(new QnA { question = "2Na4Si", answer = "Na,Na,Na,Na,Na,Na,Na,Na,Si,Si" });
        qna.Add(new QnA { question = "Li3N", answer = "Li,Li,Li,N" });

        var rand = new System.Random();
        int index = rand.Next(qna.Count);
        return qna[index];
    }

    private class QnA
    {
        public string question { get; set; }
        public string answer { get; set; }

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
