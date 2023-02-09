using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Use fixed update when you have to use a force every couple of seconds
    void Update()
    {
        // Vector3 rotation = transform.yaw;
        transform.Rotate(0, 0.5f, 0);
    }
}
