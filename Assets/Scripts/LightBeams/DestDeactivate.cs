using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestDeactivate : DestColorCheck
{
    public GameObject thingToDeactivate;
    public bool careAboutColor = false;
    public override void Activation(Color color, Ray ray)
    {
        if (!activated)
        {
            if (!careAboutColor)
            {
                if (isManaged)
                    manager.destHit();
                Debug.Log("ACTIVATED ");
                thingToDeactivate.SetActive(false);
                activated = true;
            }
            else if (color == targetColor)
            {
                if (isManaged)
                    manager.destHit();
                Debug.Log("ACTIVATED ");
                thingToDeactivate.SetActive(false);
                activated = true;
            }
        }
    }

}
