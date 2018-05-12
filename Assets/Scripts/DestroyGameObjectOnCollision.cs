using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjectOnCollision : MonoBehaviour {

  

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        //Destroy(collision.gameObject);
    }
}
