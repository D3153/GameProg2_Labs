using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    float timer = 0;
    // float direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Vector3 pointA = new Vector3(3, 1, 1);
    // Vector3 pointB = new Vector3(1, 1, 1);
    // Update is called once per frame
    
    void Update()
    {
        // transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
        if(timer<1){
            transform.Translate(Vector3.left*1 * Time.deltaTime);
            timer += Time.deltaTime;
        }
        else{
            transform.Translate(Vector3.left*-1 * Time.deltaTime);
            timer += Time.deltaTime;
            if(timer>=2){
                timer = 0;
            }
        }

    }
}
