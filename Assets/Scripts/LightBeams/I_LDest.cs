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
    public bool activated = false;

    public virtual void Activation(Material mat, Ray ray)
    {
        //Put whatever you want to happen on activation here
        //Will probably use event system
        if (!activated)
        {
            Debug.Log("Activated True");
            if (spawnNewSrc)
            {
                GameObject newLight = Instantiate(newSrc, this.transform.position, Quaternion.LookRotation(ray.direction, Vector3.up));
                newLight.GetComponentInChildren<LineRenderer>().endColor = newSrcColor;
                newLight.GetComponentInChildren<LineRenderer>().startColor = newSrcColor;
            }
            activated = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
    }
}
