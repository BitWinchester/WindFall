using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

    private bool isPickup;
    private GameObject pickupObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            print(other.gameObject.name);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Use"))
        {
            if (other.gameObject.CompareTag("Pickup"))
            {
                other.transform.parent = this.gameObject.transform;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other = null; 
    }

}
