using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Inventory))]
public class Use : MonoBehaviour
{

    private Inventory inventory;

    // Use this for initialization
    void Start()
    {

        inventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Use"))
        {
            if (inventory.HeldItem != null)
            {
                inventory.HeldItem.Use();
            }

        }
    }
}
