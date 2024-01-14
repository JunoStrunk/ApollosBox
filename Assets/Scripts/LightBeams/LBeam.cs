using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LBeam : MonoBehaviour
{
    Vector3 pos, dir;
    LineRenderer lightBeam;
    // [HideInInspector]
    public Color color;
    List<Vector3> lightPoints = new();

    private void Start()
    {
        lightBeam = GetComponent<LineRenderer>();
    }

    public void Init(Vector3 pos, Vector3 dir, Material mat)
    {
        // this.lightBeam = new LineRenderer();
        this.lightBeam = GetComponent<LineRenderer>();
        this.pos = pos;
        this.dir = dir;

        this.lightBeam.startWidth = 0.5f;
        this.lightBeam.endWidth = 0.5f;
        this.lightBeam.material = mat;
        color = lightBeam.startColor;
    }

    public void clearBeam()
    {
        lightPoints.Clear();
        lightBeam.positionCount = lightPoints.Count;
    }

    public void AddLightPoint(Vector3 point)
    {
        lightPoints.Add(point);
    }

    public void Updatebeam()
    {
        int count = 0;
        lightBeam.positionCount = lightPoints.Count;
        foreach (Vector3 iter in lightPoints)
        {
            lightBeam.SetPosition(count, iter);
            count++;
        }
    }
}
