using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision){
        m_Rigidbody = collision.gameObject.GetComponent<Rigidbody>();
        m_Rigidbody.AddForce(-collision.contacts[0].normal*500);
    }
}
