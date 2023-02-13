using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision obj){
        gameManager = FindObjectOfType<GameManager>();
        if(gameManager != null){
            gameManager.IncrementScore();
            gameObject.SetActive(false);
            Invoke("ShowTarget", 5);
        }
    }

    void ShowTarget(){
        gameObject.SetActive(true);
    }
}
