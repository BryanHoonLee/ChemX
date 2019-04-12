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
        }
        else if (element.name.Equals("Ba"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Be"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Ca"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Mg"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Ra"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Sr"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Br"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Cl"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("F"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("I"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Ar"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("He"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Kr"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Ne"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Rn"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Xe"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("B"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("C"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Ge"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("F"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Si"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("As"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("N"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("P"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Sb"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("O"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("S"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Se"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
        else if (element.name.Equals("Te"))
        {
            Instantiate(element, spawnPoint.transform.position, transform.rotation);
        }
    }

}
