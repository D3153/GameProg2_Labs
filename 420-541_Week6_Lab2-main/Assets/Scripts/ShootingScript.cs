using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    TurretComponent turret;
    public GameObject particleSystemPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5f,0.0f));
            Instantiate(particleSystemPrefab,transform.position,transform.rotation);
            if (Physics.Raycast(ray, out hit)) 
            {
                turret = GameObject.Find("Turret").GetComponent<TurretComponent>();
                if(turret != null){
                    turret.health -= 0.1f;
                    turret.slider.value = turret.health;
                }
            }
        }
    }
}
