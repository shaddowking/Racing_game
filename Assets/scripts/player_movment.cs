using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movment : MonoBehaviour
{
    public Rigidbody rb;

    public float speed;
    public float turnspeed;
    private bool isstopped;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    
    
    void Update()
    {
        if (Time.timeScale == 1)
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
        }
        
        
        
        
        

        if (isstopped == false)
        {
            Debug.Log("isstopped");

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0f,-turnspeed * Time.deltaTime,0f,Space.World);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0f,turnspeed * Time.deltaTime,0f,Space.World);
            }
        }
        
        
    }
}
