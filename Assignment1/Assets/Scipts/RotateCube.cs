using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    // public float xAngle, yAngle, zAngle;
    public float z;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        z = 0.5f;  //velocity
    }

    // void Awake()
    // {
    //     cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //     cube1.transform.position = new Vector3(0.75f, 0.0f, 0.0f);
    //     cube1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
    //     cube1.GetComponent<Renderer>().material.color = Color.red;
    //     cube1.name = "Self";
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        // cube.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        // cube.transform.Rotate (0,0,50*Time.deltaTime); //rotates 50 degrees per second around z axis
        cube.transform.Rotate(new Vector3(0,0,z)); //applying rotation
    }
}
