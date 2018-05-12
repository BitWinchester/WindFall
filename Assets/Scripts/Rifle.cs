using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Item
{


    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 12f;

    public PlayerMovement playerMovement;


    public override void Use()
    {


        Fire();
    }

    void Fire()
    {

        if (playerMovement.isAimingMode == false)
        {
            // Create the Bullet from the Bullet Prefab
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

            // Add velocity to the bullet
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

            // Destroy the bullet after 2 seconds
            Destroy(bullet, 2.0f);
        }
        else
        {
            // Create the Bullet from the Bullet Prefab
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);


            Ray camRay = playerMovement.myCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(camRay, out hit, 200f))
            {
                Vector3 playerToMouse = hit.point - transform.position;

                // Add velocity to the bullet
                bullet.GetComponent<Rigidbody>().velocity = playerToMouse.normalized * bulletSpeed;
            }


            // Destroy the bullet after 2 seconds
            Destroy(bullet, 2.0f);
        }


    }




}
