using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_controler : MonoBehaviour
{
    public Transform portalexit;

    public Transform P1;
    public Transform P2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player1")
        {
            P1.position = portalexit.position;
        }
        if (other.gameObject.tag == "player2")
        {
            P2.position = portalexit.position;
        }
    }
}
