using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestColorClearFog : DestColorCheck
{
    [SerializeField] GameObject FogParent;
    public override void Activation(Color color, Ray ray)
    {
        if (!activated && color == targetColor)
        {
            if (isManaged)
                manager.destHit();
            FogParent.SetActive(false);
            activated = true;
        }
    }
}
