using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prism : MonoBehaviour
{
    [SerializeField]
    [Range(1, 10)]
    int numSplits = 3;

    [SerializeField]
    List<Color> colors;

    bool hit = false;

    public void Split(GameObject newSrc, Ray ray)
    {
        if (!hit)
        {
            hit = true;
            Vector3 rayRot = Quaternion.AngleAxis(90, Vector3.up) * ray.direction;
            float angle = 180 / (numSplits + 1);
            for (int i = 0; i < numSplits; i++)
            {
                rayRot = Quaternion.AngleAxis(-angle, Vector3.up) * rayRot;
                GameObject newLight = Instantiate(newSrc, this.transform.position, Quaternion.LookRotation(rayRot, Vector3.up));
                // newLight.GetComponentInChildren <
                newLight.GetComponentInChildren<LineRenderer>().endColor = colors[i % colors.Count];
                newLight.GetComponentInChildren<LineRenderer>().startColor = colors[i % colors.Count];

            }
        }
    }


}
