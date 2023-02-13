using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Events;
// using System.UnityEvent;
// using UnityEvent;

public class BulletBehavior : MonoBehaviour
{
    public GameObject bullet;
    
    float totalDownTime = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        if (Input.GetButtonDown("Fire1"))
        {
            totalDownTime += Time.deltaTime;
            // Instantiate(bullet, transform.position, transform.rotation);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            bullet = Instantiate(bullet, transform.position, transform.rotation);
            Vector3 newPos = Vector3.MoveTowards(bullet.transform.position, Vector3.forward, 5f * totalDownTime);
            bullet.transform.position = newPos;
            // transform.Translate(Vector3.forward * totalDownTime);
            // bullet.AddForce(transform.up * totalDownTime,ForceMode.Impulse);
             Debug.Log("Long click");
        }
    }

    
}
