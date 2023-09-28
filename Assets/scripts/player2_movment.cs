using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_movment : MonoBehaviour
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
        
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(transform.forward * speed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(-transform.forward * speed);
            }
        }
        
        
        
        
        

        if (isstopped == false)
        {
            Debug.Log("isstopped");
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0f,-turnspeed * Time.deltaTime,0f,Space.World);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0f,turnspeed * Time.deltaTime,0f,Space.World);
            }
        }
        
        
    }
}
