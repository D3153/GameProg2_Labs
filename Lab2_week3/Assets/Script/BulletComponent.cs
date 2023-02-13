using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public GameObject bullet;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.up * force, ForceMode.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
       Destroy(gameObject, 5);
    }
}
