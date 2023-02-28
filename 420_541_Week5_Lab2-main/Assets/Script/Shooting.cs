using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource audio;
    // Ray ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f,0));
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")){
            Ray ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f,0));
            ParticleSystem part = GetComponent<ParticleSystem>();
            part.Play();
            audio.Play();
            RaycastHit hitData;
            // gameManager = FindObjectOfType<GameManager>();
            if(Physics.Raycast(ray, out hitData))
            {
                //target dissapear
                //game manager incease points
                if(hitData.collider.tag =="Target"){
                
                gameManager = GameManager.Instance;
                if(gameManager != null){
                    gameManager.IncrementScore();
                    hitData.collider.gameObject.SetActive(false);
                }
            }
            }
        }
    }
}
