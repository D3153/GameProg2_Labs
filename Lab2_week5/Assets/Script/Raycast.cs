using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
   //public Camera camera;
   //public LayerMask worldLayer;
   public GameManager gm;
   public AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        //audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        FireLaser();
    }

    void FireLaser()
    {
        if(Input.GetButtonDown("Fire1")){
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        ParticleSystem part = GetComponent<ParticleSystem>();
        part.Play();
        audio.Play();

        RaycastHit hitData;
        if (Physics.Raycast(ray, out hitData))
        {
            if(hitData.collider.tag =="Target"){
                
                gm = GameManager.Instance;
                if(gm != null){
                    gm.IncrementScore();
                    hitData.collider.gameObject.SetActive(false);
                }
            }
        }

        }
    }
}
