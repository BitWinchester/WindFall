using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
 {

    private Inventory inventory;

    public void Start()
    {
        if (this.GetComponent<Inventory>() != null)
        {
            inventory = GetComponent<Inventory>();

        }
        else print("INTERACT NEEDS A INVENTORY SCRIPT!!!");
    }

    private void Update()
    {///Need to remove this hard code to the Q key in the future 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Check if the item in the players hand isnt null 
            if(inventory.HeldItem != null)  
            {
                //First we unparent the item
                //Then turn its sphere collider back on so that we can pick it back up in the future 
                // Finally set the held item slot to null so its empty 
                inventory.HeldItem.gameObject.transform.parent = null;
                SphereCollider collider = inventory.HeldItem.gameObject.GetComponent<SphereCollider>();
              //inventory.HeldItem.GetComponent<Rigidbody>().isKinematic = true;
              //  inventory.HeldItem.GetComponent<Rigidbody>().detectCollisions = true;
                collider.enabled = true;
                inventory.HeldItem = null;
            }
            
        }
    }

}
