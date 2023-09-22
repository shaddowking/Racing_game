using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movment : MonoBehaviour
{
    public Rigidbody rb;

    public float speed;

    public float turnspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed);
        }

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
