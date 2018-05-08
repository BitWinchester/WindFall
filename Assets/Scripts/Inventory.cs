using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Item heldItem;

    public Item HeldItem
    {
        get { return heldItem; }
        set { heldItem = value; }
    }

   Item[] inventortyItems;



}
