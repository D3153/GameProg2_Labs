using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    // public GameObject bullet;
    public float force = 10;
    Rigidbody bullet;
    // Start is called before the first frame update
    void Start()
    {
         bullet = GetComponent<Rigidbody>();
         bullet.AddForce(transform.up * force,ForceMode.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
       Destroy (gameObject, 5);
    }
}
