using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointComponent : MonoBehaviour
{
    // public GameManager gameManager;
    public Text scoreText;
    public bool point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider obj)
    {
        // gameManager = FindObjectOfType<GameManager>();
        if(obj.gameObject.tag == "Point"){
            point = obj.gameObject.tag == "Point";
            Destroy(point);
            GameManager.Instance.UpdateScore();
            scoreText.text = "Score: " + GameManager.Instance.score;
            Debug.Log(GameManager.Instance.score);
        }
    }

    // public void OnCollisionEnter(Collision obj)
    // {
    //     // gameManager = FindObjectOfType<GameManager>();
    //     if(obj.gameObject.tag == "Point"){
    //         Destroy(gameObject);
    //         GameManager.Instance.UpdateScore();
    //         scoreText.text = "Score: " + GameManager.Instance.score;
    //         Debug.Log(GameManager.Instance.score);
    //     }
    // }
}
