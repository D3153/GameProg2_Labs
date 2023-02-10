using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject bullet;
    public float force = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            SpawnOject();
        }
    }

    void SpawnOject()
    {
       Instantiate(bullet, transform.position, transform.position);
    }
}
