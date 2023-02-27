using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameManager gameManager;
    // Ray ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f,0));
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")){
            Ray ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f,0));
            RaycastHit hitData;
            gameManager = FindObjectOfType<GameManager>();
            if(Physics.Raycast(ray, out hitData))
            {
                //target dissapear
                gameObject.SetActive(false);
                //game manager incease points
                if(gameManager != null){
                    gameManager.IncrementScore();
                }
            }
        }
    }
}
