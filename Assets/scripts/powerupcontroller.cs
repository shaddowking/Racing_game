using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void respawn()
    {
        gameObject.SetActive(true);

    }
    
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        Invoke("respawn",5f);
    }
}
