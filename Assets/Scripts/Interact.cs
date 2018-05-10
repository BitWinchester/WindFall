using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{


    //Characters inventory 
    private Inventory inventory;

    public void Start()
    {//Check to see if this is a inventory, if not warn  us 
        if (this.GetComponent<Inventory>() != null)
        {
            inventory = GetComponent<Inventory>();

        }
        else print("INTERACT NEEDS A INVENTORY SCRIPT!!!");
    }



    private void OnTriggerStay(Collider other)
    {


        ///Need to change this from being hard coded to E to a "Interact" Key binding 
        if (Input.GetKeyDown(KeyCode.E))
        {
            ///Need to find a better way to check if multiple items are around, which one 
            ///to pick isnt decided right now
            if (other.gameObject.GetComponent<Item>() && inventory.HeldItem == null)
            {

                GameObject go = other.gameObject;
                if (go.gameObject.GetComponent<Item>().heldLocation != null)
                {
                    go.transform.parent = go.gameObject.GetComponent<Item>().heldLocation.gameObject.transform;

                }
                go.transform.localPosition = Vector3.zero;
                go.transform.localRotation = Quaternion.identity;


                SphereCollider collider = go.gameObject.GetComponent<SphereCollider>();
                collider.enabled = false;

                inventory.HeldItem = go.gameObject.GetComponent<Item>();
            }
        }
    }



}
