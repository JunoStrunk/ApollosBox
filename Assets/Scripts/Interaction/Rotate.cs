using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int rotations = 4;
    public float interactionRadius = 5f;
    public string playerTag = "Player";
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        if (Vector3.Distance(transform.position, GetPlayerPosition()) <= interactionRadius)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                RotateObject();
            }
        }
    }

    void RotateObject()
    {
        float angle = 360f / rotations;
        transform.Rotate(rotationAxis, angle);
    }

    Vector3 GetPlayerPosition()
    {
        GameObject player = GameObject.FindGameObjectWithTag(playerTag);
        if (player != null)
        {
            return player.transform.position;
        }
        else
        {
            Debug.LogError("Player not found. Make sure the player has the correct tag.");
            return Vector3.zero;
        }
    }
}