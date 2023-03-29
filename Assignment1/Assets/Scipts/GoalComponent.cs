using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalComponent : MonoBehaviour
{
    public GameObject goal;
    // public GameObject[] points;
    // public string tagName = "Point";
    // Start is called before the first frame update
    void Start()
    {
        goal.SetActive(false);

        // points = GameObject.FindGameObjectsWithTag(tagName);
    }

    // Update is called once per frame
    void Update()
    {
        // Count();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player")){
            if(SceneManager.GetActiveScene().name == "MainLevel"){
                SceneManager.LoadScene(2);
            }
            else if(SceneManager.GetActiveScene().name == "EndLevel"){
                SceneManager.LoadScene(3);
            }
        }
    }

    // void Count()
    // {
    //     Debug.Log(PointComponent.pointCounter);
    //     if(PointComponent.pointCounter == 2)
    //     {
    //         goal.SetActive(true);
    //     }
    // }
}
