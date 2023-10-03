using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_controllerP1 : MonoBehaviour
{
    public GameObject powerupicon;
    public bool haspowerup;
    
    
    public float radius = 5f;
    public float force;
    
    void Start()
    {
        haspowerup = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (haspowerup == false)
        {
            powerupicon.SetActive(false);
        }
        else
        {
            powerupicon.SetActive(true);
        }

        if (haspowerup == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                haspowerup = false;
                Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
                foreach (Collider nearbyObjects in colliders)
                {
                    Rigidbody rb = nearbyObjects.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.AddExplosionForce(force, transform.position,radius);
                    }
                }
            }
        }
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "powerup")
        {
            haspowerup = true;
        }
    }
}
