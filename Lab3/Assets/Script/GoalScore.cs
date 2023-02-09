using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScore : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider obj){
    if(obj.tag == "Player"){
        GameManager.Instance.score++;
        if(GameManager.Instance.score == 5){
            Debug.Log("You Win!");
        }
    }
}

}
