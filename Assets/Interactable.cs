using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class Interactable : MonoBehaviour {

    private Collider _collider; 
	// Use this for initialization
	void Start () {
       _collider = GetComponent<Collider>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
