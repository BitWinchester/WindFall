using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingGUI : MonoBehaviour
{

    public List<Pawn> pawns = new List<Pawn>();

    
    // Use this for initialization
    void Start()
    {
        pawns.AddRange(FindObjectsOfType<Pawn>());
    }


    public void OnGUI()
    {
        if (GUI.Button(new Rect(10, 70, 50, 30), "EAT"))
        {
            foreach (Pawn pawn in pawns)
            {
                pawn.Eat();
            }
        }
           
      
    }
    // Update is called once per frame
    void Update()
    {

    }

}
