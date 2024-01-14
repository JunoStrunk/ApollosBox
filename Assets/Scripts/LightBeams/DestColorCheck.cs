using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestColorCheck : I_LDest
{
    public Color targetColor;
    public bool isManaged = false;
    public MultiColorManager manager;

    public override void Activation(Color color, Ray ray)
    {
        if (!activated && color == targetColor)
        {
            if (isManaged)
                manager.destHit();
            Debug.Log("ACTIVATED ");
            activated = true;
        }
    }
}
