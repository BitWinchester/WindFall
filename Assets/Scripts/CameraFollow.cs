using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject followObject;
    public Transform cameraContainer;
    private Vector3 offset;
    public float scrollSpeed = 4f;
    private float X;
    private float Y;


    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - followObject.transform.position;
    }

    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        cameraContainer.position = followObject.transform.position;

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            transform.Translate(Vector3.forward * -scrollSpeed);
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {

            transform.Translate(Vector3.forward * scrollSpeed);
        }

        if (Input.GetMouseButton(2))
        {
         //  cameraContainer.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * scrollSpeed, 0), Space.World);

            cameraContainer.Rotate(0f, Input.GetAxis("Mouse X") * scrollSpeed, 0f, Space.World);
           // cameraContainer.Rotate(-Input.GetAxis("Mouse Y") * scrollSpeed, 0f, 0f, Space.Self);
        
        }
    }
}
