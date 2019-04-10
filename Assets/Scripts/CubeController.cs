using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.SDK.Input.Handlers;
using UnityEngine;
public class CubeController : BaseFocusHandler
{
    public TextMesh textMesh;
    public void Select_Cube()
    {
        textMesh.text = "User selected Cube";
    }
    public void Rotate_Cube()
    {
        textMesh.text = "User wants to rotate Cube";
    }
  //  public override void OnFocusEnter(FocusEventData eventData)
   // {
   //     textMesh.text = "User looking at cube";
   // }
   // public override void OnFocusExit(FocusEventData eventData)
   // {
   //     textMesh.text = "User not looking at cube";
   // }
}
