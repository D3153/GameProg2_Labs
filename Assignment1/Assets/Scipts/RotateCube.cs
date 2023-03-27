using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
	public float speedRot = 100f;

    void Start()
    {

    }

	void FixedUpdate ()
	{
		float rot = Time.deltaTime * speedRot;

        transform.Rotate( new Vector3( rot, rot, rot ) );
		
	}
}
