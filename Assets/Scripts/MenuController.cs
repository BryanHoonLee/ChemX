using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.SDK.Input.Handlers;
using UnityEngine;

public class MenuController : BaseFocusHandler
{

    public TextMesh textMesh;

    public void clickedIonicButton()
    {

        textMesh.text = "Selected Ionic Bond";
    }
    public void clickedCovalentButton()
    {
        textMesh.text = "Selected Covalent Bond";
    }
    public void clickedAlkalineButton()
    {

    }
    public void clickedAlkalineEarthButton()
    {

    }
 
}
