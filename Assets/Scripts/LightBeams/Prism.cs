using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prism : MonoBehaviour
{
    [SerializeField]
    [Range(1, 10)]
    int numSplits = 3;

    bool hit = false;
    int splitsAccessed;

    private void Start()
    {
        splitsAccessed = numSplits;
    }

    public int GetNumSplits()
    {
        return numSplits;
    }
}
