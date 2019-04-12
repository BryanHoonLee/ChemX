using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.SDK.Input.Handlers;
using UnityEngine;

public class ElementController : BaseFocusHandler
{

    public TextMesh textMesh;
    public GameObject element;
    public GameObject spawnPoint;

    public void clickedElementButton()
    {
        if (element.name.Equals("Cs"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
            textMesh.text = "Cs Spawned";
        }else if (element.name.Equals("Fr"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
            textMesh.text = "Fr Spawned";
        }
        else if (element.name.Equals("Li"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
            textMesh.text = "Li Spawned";
        }
        else if (element.name.Equals("K"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
            textMesh.text = "K Spawned";
        }
        else if (element.name.Equals("Rb"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
            textMesh.text = "Rb Spawned";
        }
        else if (element.name.Equals("Na"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
            textMesh.text = "Na Spawned";
        }
    }

}
