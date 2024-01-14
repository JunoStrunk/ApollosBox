using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiColorManager : MonoBehaviour
{
    public GameObject EndLight;
    public List<I_LDest> dests;
    int numHitDests = 0;

    public void destHit()
    {
        numHitDests++;
        if (numHitDests >= dests.Count)
            Activate();
    }

    public virtual void Activate()
    {
        EndLight.SetActive(true);
    }
}
