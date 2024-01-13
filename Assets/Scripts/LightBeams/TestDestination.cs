using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDestination : I_LDest
{
    public override void Activation()
    {
        //Check material
        base.Activation();
        Debug.Log("Plus me :)");
    }
}
