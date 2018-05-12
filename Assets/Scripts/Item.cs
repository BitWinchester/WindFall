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

        meshRenderer = GetComponentInChildren<MeshRenderer>();
        sphereCollider.radius = meshRenderer.bounds.size.magnitude + 0.25f;
    }

    public virtual void Use()
    {
        print("Base class use called");
    }
}
