using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestCombine : I_LDest
{
    public List<Material> targetMats;
    int matsHitting = 0;

    public override void Activation(Material mat)
    {
        if (!activated && targetMats.Contains(mat))
        {
            activationTimer();
        }
        if (!activated && matsHitting >= targetMats.Count)
        {
            Debug.Log("Multi Mat!");
            activated = true;
        }
    }

    public IEnumerator activationTimer()
    {
        matsHitting++;
        yield return new WaitForSeconds(0.001f);
        matsHitting--;
    }
}
