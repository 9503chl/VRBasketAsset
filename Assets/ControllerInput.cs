using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerInput : MonoBehaviour
{
    public Text InputText;
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) //트리거 당겼을때
        {
            InputText.text = "Trigger";
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
        {
            Vector2 InputPoint = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
            InputText.text = InputPoint.ToString();
        }
    }
}
