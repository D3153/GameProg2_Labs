using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public GameObject bullet;
    public float force = 10;
    // Start is called before the first frame update
    void Start()
    {
         GetComponent<Rigidbody>().AddForce(transform.forward * force,ForceMode.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
