using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestSetAngle : I_LDest
{
    public GameObject thingToActivate;
    public override void Activation(Color color, Ray ray)
    {
        //Put whatever you want to happen on activation here
        //Will probably use event system
        if (!activated)
        {
            Debug.Log("Activated True");
            thingToActivate.SetActive(true);
            activated = true;
        }
    }

}
