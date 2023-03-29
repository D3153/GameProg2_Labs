using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class PointComponent : MonoBehaviour
{
    // public GameManager gameManager;
    // public Text scoreText;
    public GameObject point;
    public GameObject goal;
    public static int pointCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        // public GameObject point;
        pointCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider obj)
    {
        if(obj.gameObject.tag == "Player"){
            point.SetActive(false);
            GameManager.Instance.UpdateScore();
            Debug.Log(GameManager.score);
            pointCounter++;
        }
        if(pointCounter == 2){
            goal.SetActive(true);
        }
    }
}
