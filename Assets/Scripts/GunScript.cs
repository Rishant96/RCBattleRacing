using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f; 
    public float imapactForce = 100f;
    public Camera fpsCam;
    public GameObject impactEffect; 
    public AudioSource gunShot;

    void Update()
    {
        if (Input.GetKeyDown(("space")))
        {
            gunShot.Play();
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        var bulletDirection = new Vector3(fpsCam.transform.forward.x, fpsCam.transform.forward.y + 0.125f, fpsCam.transform.forward.z);
        if (Physics.Raycast(fpsCam.transform.position, bulletDirection, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if  (hit.transform.name == "CarWaypointBased" && hit.rigidbody != null) {
                Debug.Log("hitting car");
                hit.rigidbody.AddForce (hit.normal * imapactForce);
            }
        }

        GameObject impact = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 2.0f);
    }
}
