using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //vector3(0.0f,1.0f,0.0f) == vector3.up
            //transform.Translate(Vector3(0.0f,1.0f,0.0f) * Time.deltaTime);
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            //vector3(0.0f,1.0f,0.0f) == vector3.up
            //transform.Translate(Vector3(0.0f,1.0f,0.0f) * Time.deltaTime);
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            //vector3(0.0f,1.0f,0.0f) == vector3.up
            //transform.Translate(Vector3(0.0f,1.0f,0.0f) * Time.deltaTime);
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            //vector3(0.0f,1.0f,0.0f) == vector3.up
            //transform.Translate(Vector3(0.0f,1.0f,0.0f) * Time.deltaTime);
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}
