using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LDest : MonoBehaviour
{
    public bool activated = false;

    public void Activation()
    {
        //Put whatever you want to happen on activation here
        //Will probably use event system
        if (!activated)
        {
            Debug.Log("Activated True");
            activated = true;
        }
    }
}
