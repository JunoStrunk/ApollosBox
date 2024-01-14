using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public float pickupRange = 2f; // Set the pickup range
    public string pickupTag = "PickUp"; // Set the pickup tag
    public Transform holdPosition; // Set the position where the object will be held

    private GameObject heldObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (heldObject == null)
            {
                TryPickup();
            }
            else
            {
                DropObject();
            }
        }

        if (heldObject != null)
        {
            MoveHeldObject();
        }
    }

    void TryPickup()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, pickupRange);

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag(pickupTag))
            {
                // Perform pickup action
                heldObject = collider.gameObject;
                heldObject.GetComponent<Rigidbody>().isKinematic = true;
                heldObject.transform.position = holdPosition.position;
                heldObject.transform.parent = transform;
            }
        }
    }

    void DropObject()
    {
        // Perform drop action
        heldObject.GetComponent<Rigidbody>().isKinematic = false;
        heldObject.transform.parent = null;
        heldObject = null;
    }

    void MoveHeldObject()
    {
        // Move the held object to the hold position
        heldObject.transform.position = holdPosition.position;

        // Optionally, you can add logic to rotate the held object based on player input
        // Example: heldObject.transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
    }

    private void OnDrawGizmosSelected()
    {
        // Visualize the pickup range in the Unity Editor
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, pickupRange);
    }
}