using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestColorCheck : I_LDest
{
    public Color targetColor;
    public override void Activation(Color color, Ray ray)
    {

        if (!activated && color == targetColor)
        {
            Debug.Log("ACTIVATED ");
            activated = true;
        }
    }
}
