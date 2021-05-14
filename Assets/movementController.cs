using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public int MaxJumps = 1;
    int Jumps;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jumps = MaxJumps;
    }
    void FixedUpdate()
    {
        float mH = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown("space"))
        {
            if(Jumps>0)
            {
                rb.velocity = new Vector3(mH * speed, speed * 5, rb.velocity.z);
                Jumps -= 1;
            }
            
        }
        else
        {
            rb.velocity = new Vector3(mH * speed, rb.velocity.y, rb.velocity.z);
        }

        
    }
    void OnCollisionEnter(Collision Col)
    {
        Jumps = MaxJumps;
    }
}
