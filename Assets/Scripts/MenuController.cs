using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.SDK.Input.Handlers;
using UnityEngine;

public class MenuController : BaseFocusHandler
{

    public TextMesh textMesh;
    public GameObject Element;

    public void clickedIonicButton()
    {

        textMesh.text = "Selected Ionic Bond";
    }
    public void clickedCovalentButton()
    {
        textMesh.text = "Selected Covalent Bond";
    }
    public void clickedElementButton()
    {
        if (Element.name.Equals("Cs"))
        {
            Instantiate(Element, transform.position, transform.rotation);
            textMesh.text = "Cs Spawned";
        }else if (Element.name.Equals("Fr"))
        {
            Instantiate(Element, transform.position, transform.rotation);
            textMesh.text = "Fr Spawned";
        }
        else if (Element.name.Equals("Li"))
        {
            Instantiate(Element, transform.position, transform.rotation);
            textMesh.text = "Li Spawned";
        }
        else if (Element.name.Equals("K"))
        {
            Instantiate(Element, transform.position, transform.rotation);
            textMesh.text = "K Spawned";
        }
        else if (Element.name.Equals("Rb"))
        {
            Instantiate(Element, transform.position, transform.rotation);
            textMesh.text = "Rb Spawned";
        }
        else if (Element.name.Equals("Na"))
        {
            Instantiate(Element, transform.position, transform.rotation);
            textMesh.text = "Na Spawned";
        }
    }
    public void clickedAlkalineEarthButton()
    {

    }
 
}
