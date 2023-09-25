using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movment : MonoBehaviour
{
    public Rigidbody rb;

    public float speed;
    public float turnspeed;
    private float stopspeed;
    private bool isstopped;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    
    
    void Update()
    {
        
        if (rb.velocity == Vector3.zero)
        {
            isstopped = true;
        }
        else
        {
            isstopped = false;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed);
        }
        
        
        
        

        if (isstopped == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0f,-turnspeed * Time.deltaTime,0f,Space.World);
                Debug.Log("turning left");
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0f,turnspeed * Time.deltaTime,0f,Space.World);
                Debug.Log("turning right");
            }
        }
        
        
    }
}
