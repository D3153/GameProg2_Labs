using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Events;
// using System.UnityEvent;
// using UnityEvent;

public class BulletBehavior : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletToSpawn;
    public BulletComponent bc;
    float totalDownTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            totalDownTime += Time.deltaTime;
            // Instantiate(bullet, transform.position, transform.rotation);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            bulletToSpawn = Instantiate(bullet, transform.position, transform.rotation);
            bc = bulletToSpawn.GetComponent<BulletComponent>();

            if (bulletToSpawn != null)
            {
                bc.force = totalDownTime*30;
                totalDownTime = 0;
            }
            
        }
    }

    
}
