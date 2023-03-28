using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointComponent : MonoBehaviour
{
    public GameManager gameManager;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collision obj)
    {
        gameManager = FindObjectOfType<GameManager>();
        if(obj.gameObject.tag == "Point"){
            Destroy(gameObject);
            scoreText.text = "Score: " + gameManager.score;
            Debug.Log(gameManager.score);
        }
    }

    public void OnCollisionEnter(Collision obj)
    {
        gameManager = FindObjectOfType<GameManager>();
        if(obj.gameObject.tag == "Point"){
            Destroy(gameObject);
            scoreText.text = "Score: " + gameManager.score;
            Debug.Log(gameManager.score);
        }
    }
}
