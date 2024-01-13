using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestColorCheck : I_LDest
{
    public Material targetMat;
    public override void Activation(Material mat)
    {
        if (!activated && mat == targetMat)
        {
            // Debug.Log("ACTIVATED " + targetMat.name);
            activated = true;
        }
    }
}
