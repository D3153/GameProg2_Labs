using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretComponent : MonoBehaviour
{
    public float maxAngle = 45;
    public Vector3 rotation;
    public Transform target;
    public float turretAngle;
    Vector3 ogDirection;
    // Start is called before the first frame update
    void Start()
    {
        ogDirection = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        var orthogonal = Vector3.Dot(Vector3.up, Vector3.forward); // 0
        // var angle = Mathf.Acos( Vector3.Dot(Vector3.up, Vector3.forward));
        var directionToTarget = (target.transform.position - transform.position);
        var angle = Mathf.Acos( Vector3.Dot(transform.forward, directionToTarget/directionToTarget.magnitude));
        turretAngle = angle*Mathf.Rad2Deg;
        if(turretAngle<maxAngle){
            transform.localEulerAngles = rotation;
            transform.localRotation = Quaternion.Euler(rotation);
            transform.rotation = Quaternion.LookRotation(directionToTarget);
        }
        else{
            transform.rotation = Quaternion.LookRotation(ogDirection);
        }
    }
}
