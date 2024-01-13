using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_LDest : MonoBehaviour
{
    public bool activated = false;

    public virtual void Activation(Material mat)
    {
        //Put whatever you want to happen on activation here
        //Will probably use event system
        if (!activated)
        {
            Debug.Log("Activated True");
            activated = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
    }
}
