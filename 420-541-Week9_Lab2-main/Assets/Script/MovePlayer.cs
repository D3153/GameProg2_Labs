using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
       ProcessMovement();
    }
    
    void ProcessMovement()
    { 
        Vector3 move = new Vector3(Input.GetAxis("Horizontal")*speed, 0, Input.GetAxis("Vertical")*speed);
        rb.velocity = move;
        // rb.velocity += move* Time.fixedDeltaTime ;
    }
}
