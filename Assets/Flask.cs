using System;
using System.Collections;
using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.SDK.Input.Handlers;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Flask : BaseFocusHandler
{  
    public bool isFinished;
    public Text elemList;
    public Text questionText;
    public Text checkAnswerText;
    public Text resultText;

    public ScientistBehavior scientistAnimation;

    private QnA prompt;
    private List<Element> elementList = new List<Element>();

    // Start is called before the first frame update
    void Start()
    {
        prompt = GenerateQnA();
        questionText.text = "Create\n  " + prompt.question;
        isFinished = false;
        elemList.text = "Elements: \n";
        checkAnswerText.text = "Click to\n Check Answer";
        resultText.text = "";

        scientistAnimation = FindObjectOfType<ScientistBehavior>();
    }

    List<Element> GetElementList()
    {
        return elementList;
    }
    public void Next_Question()
    {
        prompt = GenerateQnA();
        questionText.text = "Create\n  " + prompt.question;
        isFinished = false;
        elemList.text = "Elements: \n";
        checkAnswerText.text = "Click to\n Check Answer";
        resultText.text = "";

        elementList.Clear();
    }
    public void Check_Answer()
    {
            isFinished = true;
            if (CheckAnswer())
            {
                checkAnswerText.text = "Correct!";
              
                scientistAnimation.PlayWin();
            }
            else
            {
            checkAnswerText.text = "Incorrect";
                
                scientistAnimation.PlayLose();
            }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFinished = true;
            if (CheckAnswer())
            {
                resultText.text = "You Win!";
                checkAnswerText.text = "";
                scientistAnimation.PlayWin();
            }
            else
            {
                resultText.text = "You Lose.";
                checkAnswerText.text = "";
                scientistAnimation.PlayLose();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isFinished)
        {
            if (other.gameObject.CompareTag("Alkali Metal"))
            {
                name = UpdateElementList(other.name);
                elementList.Add(new Element("Alkali Metal", name, +1));
                other.gameObject.SetActive(false);
            }
            if (other.gameObject.CompareTag("Alkaline Earth Metal"))
            {
                name = UpdateElementList(other.name);
                elementList.Add(new Element("Alkali Earth Metal", name, +2));
                other.gameObject.SetActive(false);
            }
            if (other.gameObject.CompareTag("Nonmetal3"))
            {
                name = UpdateElementList(other.name);
                elementList.Add(new Element("Nonmetal", name, -3));
                other.gameObject.SetActive(false);
            }
            if (other.gameObject.CompareTag("Nonmetal4"))
            {
                name = UpdateElementList(other.name);
                elementList.Add(new Element("Nonmetal", name, -4));
                other.gameObject.SetActive(false);
            }
            if (other.gameObject.CompareTag("Nonmetal5"))
            {
                name = UpdateElementList(other.name);
                elementList.Add(new Element("Nonmetal", name, -5));
                other.gameObject.SetActive(false);
            }
            if (other.gameObject.CompareTag("Nonmetal6"))
            {
                name = UpdateElementList(other.name);
                elementList.Add(new Element("Nonmetal", name, -6));
                other.gameObject.SetActive(false);
            }
            if (other.gameObject.CompareTag("Halogen"))
            {
                name = UpdateElementList(other.name);
                elementList.Add(new Element("Halogen", name, -7));
                other.gameObject.SetActive(false);
            }
            if (other.gameObject.CompareTag("Noble Gas"))
            {
                name = UpdateElementList(other.name);
                elementList.Add(new Element("Noble Gas", name, 0));
                other.gameObject.SetActive(false);
            }
        }
    }

    private bool CheckAnswer()
    {
        List<string> answer = new List<string>();
        string[] temp = prompt.answer.Split(',');

        foreach (string s in temp)
        {
            answer.Add(s);
        }


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

        for (int i = 0; i < elementList.Count; i++)
        {
            if (answer.Contains(elementList[i].name))
            {
                answer.Remove(elementList[i].name);
                elementList.Remove(elementList[i]);
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

    private string UpdateElementList(string elementName)
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
        return temp[0];
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
