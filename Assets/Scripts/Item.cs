using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : MonoBehaviour
{

    SphereCollider sphereCollider;
    MeshRenderer meshRenderer;
    public GameObject heldLocation;
    Rigidbody rb;

    private void Start()
    {
        if (gameObject.GetComponent<SphereCollider>() != null)
        {
            sphereCollider = GetComponent<SphereCollider>();
        }
        else
        {
            sphereCollider = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
            sphereCollider.isTrigger = true;
        }

        //if (gameObject.GetComponent<Rigidbody>() != null)
        //{
        //    rb = GetComponent<Rigidbody>();
        //    rb.isKinematic = true;
        //    rb.detectCollisions = true;
        //}
        //else
        //{
        //    rb = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
        //    rb.isKinematic = true;
        //    rb.detectCollisions = true;
        //}


        meshRenderer = GetComponentInChildren<MeshRenderer>();
        sphereCollider.radius = meshRenderer.bounds.size.magnitude + 0.25f;
    }

    public virtual void Use()
    {
        print("Base class use called");
    }
}
