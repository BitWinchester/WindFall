using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food :Item, IEdible {


    public static List<GameObject> Foods = new List<GameObject>();

    public void Eat(GameObject eatenObject)
    {
        Destroy(eatenObject);

        Foods.Remove(eatenObject);
        
    }

    private void Awake()
    {
        Foods.Add(gameObject);
       
    }
}
