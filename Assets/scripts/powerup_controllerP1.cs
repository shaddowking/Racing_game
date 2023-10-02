using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_controllerP1 : MonoBehaviour
{
    public GameObject powerupicon;
    public bool haspowerup;
    
    
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
