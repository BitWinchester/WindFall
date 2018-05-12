using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    public float zoom = 2f;
    public Camera myCamera;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            print("ScrollingUP");
            transform.position = new Vector3(myCamera.transform.position.x + zoom, myCamera.transform.position.y, myCamera.transform.position.z);
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            print("ScrollingDOWN");
            transform.position = new Vector3(myCamera.transform.position.x - zoom, myCamera.transform.position.y, myCamera.transform.position.z);
        }


    }
}
