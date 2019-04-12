using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.SDK.Input.Handlers;
using UnityEngine;
public class CheckAnswer : BaseFocusHandler
{
    public Flask flask;
    public void Check_Answer()
    {
        flask.Check_Answer();
    }
}
