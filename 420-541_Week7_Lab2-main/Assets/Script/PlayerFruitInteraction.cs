using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using static GameManager;

public class PlayerFruitInteraction : MonoBehaviour
{
    GameManager gm;
    public float score = 0;
    // GameManager.slider slider;
    // public GameObject fruit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        gm = FindObjectOfType<GameManager>();   
        if(col.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Ground"){
            Destroy(gameObject);
            
        }
    }
}
