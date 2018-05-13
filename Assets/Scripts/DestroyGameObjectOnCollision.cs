using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjectOnCollision : MonoBehaviour
{


    public GameObject dontDestroy;
    private void OnCollisionEnter(Collision collision)
    {

        //Destroy(collision.gameObject);

        Destroy(gameObject);

    }
}
