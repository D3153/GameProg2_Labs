using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody m_Rigidbody;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 m_Input = new Vector3(-Input.GetAxis("Vertical"), 0 , Input.GetAxis("Horizontal"));
        
        m_Rigidbody.AddForce(m_Input * speed);
    }
}
