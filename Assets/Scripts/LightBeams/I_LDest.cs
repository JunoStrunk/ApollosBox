using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_LDest : MonoBehaviour
{
    public bool spawnNewSrc = false;
    [SerializeField]
    GameObject newSrc;
    [SerializeField]
    Color newSrcColor;
    [SerializeField]
    float newSrcAngle;
    public bool activated = false;

    public virtual void Activation(Color color, Ray ray)
    {
        //Put whatever you want to happen on activation here
        //Will probably use event system
        if (!activated)
        {
            Debug.Log("Activated True");
            if (spawnNewSrc)
            {
                Vector3 rayRot = Quaternion.AngleAxis(newSrcAngle, Vector3.up) * ray.direction;
                GameObject newLight = Instantiate(newSrc, this.transform.position, Quaternion.LookRotation(rayRot, Vector3.up));
                newLight.GetComponentInChildren<LineRenderer>().endColor = newSrcColor;
                newLight.GetComponentInChildren<LineRenderer>().startColor = newSrcColor;
            }
            activated = true;
        }
    }
}
